﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SMAdvancedC_DotNet.RepositoryPattern.Persistance.Repositories;

namespace SMAdvancedC_DotNet.RepositoryPattern.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogController : ControllerBase
    {
        internal readonly IBlogRepository _blogRepository;

        public BlogController(IBlogRepository blogRepository)
        {
            _blogRepository = blogRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetBlogListAsync(int pageNo, int pageSize, CancellationToken cs)
        {
            var lst = await _blogRepository.GetBlogListAsync(pageNo, pageSize, cs);
            return Ok(lst);
        }

       
    }
}

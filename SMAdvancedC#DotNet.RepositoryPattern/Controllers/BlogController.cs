﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SMAdvancedC_DotNet.RepositoryPattern.Models;
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

        [HttpGet("V1")]
        public async Task<IActionResult> GetBlogListAsyncV1(int pageNo, int pageSize, CancellationToken cs)
        {
            var lst = await _blogRepository.GetBlogListAsyncV1(pageNo, pageSize, cs);
            return Ok(lst);
        }
        [HttpPost]
        public async Task<IActionResult> CreateBlogAsync(BlogRequest requestModel, CancellationToken cs)
        {
            var result = await _blogRepository.CreateBlogAsync(requestModel, cs);
            return Ok(result);
        }

        [HttpPut("{BlogId}")]
        public async Task<IActionResult> UpdateBlogAsync(BlogRequest requestModel, CancellationToken cs)
        {
            var result = await _blogRepository.UpdateBlogAsync(requestModel, cs);
            return Ok(result);
        }

        [HttpDelete("{BlogId}")]
        public async Task<IActionResult> DeleteBlogAsync(int blogId, CancellationToken cs)
        {
            var result = await _blogRepository.DeleteBlogAsync(blogId, cs);
            return Ok(result);
        }
    }
}

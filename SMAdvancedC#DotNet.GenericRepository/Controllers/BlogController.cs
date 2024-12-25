using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SMAdvancedC_DotNet.GenericRepository.Persistance.Repositories;
using SMAdvancedC_DotNet.shared;

namespace SMAdvancedC_DotNet.GenericRepository.Controllers
{
    [Route("api/GenericRepository/Blog")]
    [ApiController]
    public class BlogController : ControllerBase
    {
        private readonly IBlogRepository _blogRepository;

        public BlogController(IBlogRepository blogRepository)
        {
            _blogRepository = blogRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetBlogsAsync(int pageNo, int pageSize, CancellationToken cs)
        {
            var query = _blogRepository.Query().Paginate(pageNo, pageSize);
            var lst = await query.ToListAsync(cs);

            return Ok(lst);
        }
    }
}

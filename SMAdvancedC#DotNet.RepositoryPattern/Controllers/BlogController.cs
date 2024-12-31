using Microsoft.AspNetCore.Mvc;
using SMAdvancedC_DotNet.RepositoryPattern.Models;
using SMAdvancedC_DotNet.RepositoryPattern.Persistance.Repositories;

namespace SMAdvancedC_DotNet.RepositoryPattern.Controllers
{
    [Route("api/RepositoryPattern/Blog")]
    [ApiController]
    public class BlogController : ControllerBase
    {
        internal readonly IBlogRepository _blogRepository;

        public BlogController(IBlogRepository blogRepository)
        {
            _blogRepository = blogRepository;
        }

        #region GetBlogListAsync

        [HttpGet("List")]
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
        #endregion


        #region CreateBlogAsync

        [HttpPost]
        public async Task<IActionResult> CreateBlogAsync(BlogRequest requestModel, CancellationToken cs)
        {
            var result = await _blogRepository.CreateBlogAsync(requestModel, cs);
            return Ok(result);
        }
        #endregion


        #region UpdateBlogAsync
        [HttpPut("{BlogId}")]
        public async Task<IActionResult> UpdateBlogAsync (int BlogId,BlogRequest requestModel, CancellationToken cs)
        {
            var result = await _blogRepository.UpdateBlogAsync( BlogId,requestModel, cs);
            return Ok(result);
        }
        #endregion


        [HttpDelete("{BlogId}")]
        public async Task<IActionResult> DeleteBlogAsync(int BlogId, CancellationToken cs)
        {
            var result = await _blogRepository.DeleteBlogAsync(BlogId, cs);
            return Ok(result);
        }
    }
}

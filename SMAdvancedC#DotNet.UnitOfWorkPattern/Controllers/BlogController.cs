using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SMAdvancedC_DotNet.UnitOfWorkPattern.Persistance;

namespace SMAdvancedC_DotNet.UnitOfWorkPattern.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public BlogController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        public async Task<IActionResult> GetBlogListAsync(int pageNo, int pageSize, CancellationToken cs)
        {
            var lst = await _unitOfWork.BlogRepository.GetBlogListAsync(pageNo, pageSize, cs);
            return Ok(lst);
        }
    }
}

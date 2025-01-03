using Microsoft.AspNetCore.Mvc;
using SMAdvancedC_DotNet.UnitOfWorkPattern.Persistance;
using SMAdvancedC_DotNet.shared;
using Microsoft.EntityFrameworkCore;
using SMAdvancedC_DotNet.UnitOfWorkPattern.Model;

namespace SMAdvancedC_DotNet.UnitOfWorkPattern.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogController : ControllerBase
    {
        internal readonly IUnitOfWork _unitOfWork;

        public BlogController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }


        #region GetBlogsAsync

        [HttpGet]
        public async Task<IActionResult> GetBlogsAsync(int pageNo, int pageSize, CancellationToken cs)
        {
            var query = _unitOfWork.BlogRepository.Query().Paginate(pageNo, pageSize);
            var lst = await query.ToListAsync(cs);

            return Ok(lst);
        }
        #endregion

       




    }
}

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SMAdvancedC_DotNet.GenericRepository.Persistance.Repositories;

namespace SMAdvancedC_DotNet.GenericRepository.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogController : ControllerBase
    {
        private readonly IBlogRepository _blogRepository;
    }
}

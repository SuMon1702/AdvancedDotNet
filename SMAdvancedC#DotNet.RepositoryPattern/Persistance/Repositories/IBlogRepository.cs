using SMAdvancedC_DotNet.RepositoryPattern.Models;
using SMAdvancedC_DotNet.Utlis;

namespace SMAdvancedC_DotNet.RepositoryPattern.Persistance.Repositories
{
    public interface IBlogRepository
    {
        Task<Result<List<BlogModel>>> GetBlogListAsync (int pageNo, int pageSize, CancellationToken cs);
    }
}

using SMAdvancedC_DotNet.Database.Models;
using SMAdvancedC_DotNet.UnitOfWorkPattern.Model;
using SMAdvancedC_DotNet.Utlis;

namespace SMAdvancedC_DotNet.UnitOfWorkPattern.Persistence.Repositories;

public interface IBlogRepository : IRepositoryBase<TblBlog>
{
    Task<Result<List<BlogModel>>> GetBlogListAsync(int pageNo, int pageSize, CancellationToken cs);
   // Task<Result<BlogModel>> GetBlogByIdAsync(int blogId, CancellationToken cs);


}

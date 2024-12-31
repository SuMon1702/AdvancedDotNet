using SMAdvancedC_DotNet.RepositoryPattern.Models;
using SMAdvancedC_DotNet.Utlis;
using System.Collections.Generic;

namespace SMAdvancedC_DotNet.RepositoryPattern.Persistance.Repositories
{
    public interface IBlogRepository
    {
        Task<Result<List<BlogModel>>> GetBlogListAsync (int pageNo, int pageSize, CancellationToken cs);
        Task<Result<List<BlogModel>>> GetBlogListAsyncV1(int pageNo, int pageSize, CancellationToken cs);
        Task<Result<BlogRequest>> CreateBlogAsync(BlogRequest requestModel, CancellationToken cs);
        Task<Result<BlogRequest>> UpdateBlogAsync(int blogId,BlogRequest requestModel, CancellationToken cs);
        Task<Result<BlogModel>> DeleteBlogAsync(int blogId, CancellationToken cs);
        
    }
}

using SMAdvancedC_DotNet.Database.Models;
using SMAdvancedC_DotNet.UnitOfWorkPattern.Model;
using SMAdvancedC_DotNet.UnitOfWorkPattern.Persistance.Repositories;

namespace SMAdvancedC_DotNet.UnitOfWorkPattern.Persistance.Repositories
{
    public interface IBlogRepository : IRepositoryBase<TblBlog>
    {
        
    }
}

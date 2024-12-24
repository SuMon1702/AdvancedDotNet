using SMAdvancedC_DotNet.Database.Models;
using SMAdvancedC_DotNet.RepositoryPattern.Persistance.Repositories;

namespace SMAdvancedC_DotNet.UnitOfWorkPattern.Persistance.Repositories
{
    public class BlogRepository :RepositoryBase<TblBlog> ,IBlogRepository
    {
        public BlogRepository(AppDbContext context) : base(context)
        {
        }
    }
}

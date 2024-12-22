using SMAdvancedC_DotNet.Database.Models;

namespace SMAdvancedC_DotNet.GenericRepository.Persistance.Repositories
{
    public class BlogRepository : RepositoryBase<TblBlog>, IBlogRepository
    {
        public BlogRepository(AppDbContext context) : base(context)
        {
        }
    }
}

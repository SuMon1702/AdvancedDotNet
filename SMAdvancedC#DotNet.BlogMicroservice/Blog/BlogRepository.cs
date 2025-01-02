using SMAdvancedC_DotNet.BlogMicroservice.Features;
using SMAdvancedC_DotNet.Database.Models;
using SMAdvancedC_DotNet.GenericRepository.Persistance.Repositories;

namespace SMAdvancedC_DotNet.BlogMicroservice.Blog
{
    public class BlogRepository : RepositoryBase<TblBlog>, IBlogRepository
    {
        public BlogRepository(AppDbContext context) : base(context)
        {
        }
    }
}

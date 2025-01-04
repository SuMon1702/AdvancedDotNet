using SMAdvancedC_DotNet.Database.Models;
using SMAdvancedC_DotNet.UnitOfWorkPattern.Model;

namespace SMAdvancedC_DotNet.UnitOfWorkPattern.Persistance.Repositories
{
    public class BlogRepository : RepositoryBase<TblBlog>, IBlogRepository
    {
        public BlogRepository(AppDbContext context)
            : base(context) { }

        public Task CreateBlogAsync(BlogRequest requestModel, CancellationToken cs)
        {
            return Task.CompletedTask;
        }
    }
}

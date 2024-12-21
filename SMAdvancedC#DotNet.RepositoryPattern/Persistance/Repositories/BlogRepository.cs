using Microsoft.EntityFrameworkCore;
using SMAdvancedC_DotNet.Database.Models;
using SMAdvancedC_DotNet.RepositoryPattern.Models;
using SMAdvancedC_DotNet.Utlis;

namespace SMAdvancedC_DotNet.RepositoryPattern.Persistance.Repositories
{
    public class BlogRepository : IBlogRepository
    {
        private readonly AppDbContext _context;
        public BlogRepository(AppDbContext context)
        {
            _context = context;
        }
        public async Task<Result<List<BlogModel>>> GetBlogListAsync(int pageNo, int pageSize, CancellationToken cs)
        {
            Result<List<BlogModel>> result;
           try
            {
                var query = _context.TblBlogs.Where(x => x.IsDeleted == false).Skip((pageNo - 1) * pageSize).Take(pageSize);
                var lst = await query.Select(x => new BlogModel()
                {
                    BlogId = x.BlogId,
                    BlogTitle = x.BlogTitle,
                    BlogAuthor = x.BlogAuthor,
                    BlogContent = x.BlogContent,
                }).ToListAsync(cs);

                result= Result<List<BlogModel>>.Success(lst);
            }
            catch (Exception ex)
            {
                result = Result<List<BlogModel>>.Fail(ex);
            }
            return result;
        }
    }
}

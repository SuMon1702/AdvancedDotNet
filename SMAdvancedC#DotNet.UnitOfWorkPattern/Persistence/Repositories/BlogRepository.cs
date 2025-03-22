using DocumentFormat.OpenXml.Wordprocessing;
using Microsoft.EntityFrameworkCore;
using MySqlX.XDevAPI.Common;
using SMAdvancedC_DotNet.Database.Models;
using SMAdvancedC_DotNet.shared;
using SMAdvancedC_DotNet.UnitOfWorkPattern.Model;
using SMAdvancedC_DotNet.Utlis;

namespace SMAdvancedC_DotNet.UnitOfWorkPattern.Persistence.Repositories
{
    public class BlogRepository : RepositoryBase<TblBlog>, IBlogRepository
    {
        public BlogRepository(AppDbContext context)
            : base(context) { }

        public async Task<Result<List<BlogModel>>> GetBlogListAsync(int pageNo, int pageSize, CancellationToken cs)
        {
            Result<List<BlogModel>> response;
            try
            {
                var query = _context.TblBlogs.Paginate(pageNo, pageSize);

                var lst = await query.Select(x => new BlogModel()
                {
                    BlogId = x.BlogId,
                    BlogTitle = x.BlogTitle,
                    BlogAuthor = x.BlogAuthor,
                    BlogContent = x.BlogContent,
                }).ToListAsync(cs);
                response = Result<List<BlogModel>>.Success(lst);
            }
            catch (Exception ex)
            {
                response = Result<List<BlogModel>>.Fail(ex);
            }
            return response;
        }

        public async Task<Result<BlogModel>> GetBlogByIdAsync(int blogId, CancellationToken cs)
        {
            Result<BlogModel> response;
            try
            {
                var query = _context.TblBlogs.Where(x => x.BlogId == blogId);
                var blog = await query.Select(x => new BlogModel()
                {
                    BlogId = x.BlogId,
                    BlogTitle = x.BlogTitle,
                    BlogAuthor = x.BlogAuthor,
                    BlogContent = x.BlogContent,
                }).FirstOrDefaultAsync(cs);
                if (blog == null)
                {
                    response = Result<BlogModel>.Fail("Blog not found.");
                }
                else
                {
                    response = Result<BlogModel>.Success(blog);
                }
            }
            catch (Exception ex)
            {
                response = Result<BlogModel>.Fail(ex);
            }
            return response;

        }

    }

}


using Microsoft.EntityFrameworkCore;
using SMAdvancedC_DotNet.Database.Models;
using SMAdvancedC_DotNet.RepositoryPattern.Models;
using SMAdvancedC_DotNet.shared;
using SMAdvancedC_DotNet.Utlis;
using SMAdvancedC_DotNet.RepositoryPattern.Persistance;


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

            var query = _context.TblBlogs
            .Where(x => x.IsDeleted == false)
            .Paginate(pageNo, pageSize);

            var lst = await query.Select(x => new BlogModel()
            {
                BlogId = x.BlogId,
                BlogTitle = x.BlogTitle,
                BlogAuthor = x.BlogAuthor,
                BlogContent = x.BlogContent,
            }).ToListAsync(cs);

            result = Result<List<BlogModel>>.Success(lst);

            return result;
        }

        public async Task<Result<List<BlogModel>>> GetBlogListAsyncV1(int pageNo, int pageSize, CancellationToken cs)
        {
            Result<List<BlogModel>> result;
            var query = _context.TblBlogs
                .Paginate(pageNo, pageSize);
            var lst = await query.Select(x => new BlogModel()
            {
                BlogId = x.BlogId,
                BlogTitle = x.BlogTitle,
                BlogAuthor = x.BlogAuthor,
                BlogContent = x.BlogContent,
                IsDeleted = true

            }).ToListAsync(cs);

            result = Result<List<BlogModel>>.Success(lst);

            return result;
        }


        public async Task<Result<BlogRequest>> CreateBlogAsync(BlogRequest requestModel, CancellationToken cs)
        {
            Result<BlogRequest> result;
           
                var item = new TblBlog
                {
                    BlogTitle = requestModel.BlogTitle,
                    BlogAuthor = requestModel.BlogAuthor,
                    BlogContent = requestModel.BlogContent,
                    IsDeleted = true,
                };

                await _context.TblBlogs.AddAsync(item, cs);
                await _context.SaveChangesAsync(cs);

                result = Result<BlogRequest>.Success(requestModel);
            
            
            return result;
        }

        public async Task<Result<BlogRequest>> UpdateBlogAsync(int blogId, BlogRequest requestModel, CancellationToken cs)
        {
            Result<BlogRequest> result;

           
                var item = await _context.TblBlogs.FirstOrDefaultAsync(x => x.BlogId == blogId, cs);

                if (item is null)
                {
                    result = Result<BlogRequest>.Fail("No Data Found");
                    return result;
                }
                item.BlogTitle = requestModel.BlogTitle;
                item.BlogAuthor = requestModel.BlogAuthor;
                item.BlogContent = requestModel.BlogContent;

                _context.TblBlogs.Update(item);
                await _context.SaveChangesAsync(cs);

                result = Result<BlogRequest>.Success(requestModel);
           

            return result;
        }

        public async Task<Result<BlogModel>> DeleteBlogAsync(int blogId, CancellationToken cs)
        {
            Result<BlogModel> result;

            
                var item = await _context.TblBlogs.FirstOrDefaultAsync(x => x.BlogId == blogId, cs);

                if (item is null)
                {
                    result = Result<BlogModel>.Fail("No Data Found");
                    return result;
                }

                item.IsDeleted = false;

                // _context.TblBlogs.Update(item);
                await _context.SaveChangesAsync(cs);

                result = Result<BlogModel>.Success();
            

           
            return result;
        }

        
    }
}

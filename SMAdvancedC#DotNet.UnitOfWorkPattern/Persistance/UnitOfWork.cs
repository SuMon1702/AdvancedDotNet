using SMAdvancedC_DotNet.Database.Models;
using SMAdvancedC_DotNet.UnitOfWorkPattern.Persistance.Repositories;

namespace SMAdvancedC_DotNet.UnitOfWorkPattern.Persistance;

public class UnitOfWork : IUnitOfWork
{
    internal readonly AppDbContext _context;
    public IBlogRepository BlogRepository { get; set; }

    public UnitOfWork(AppDbContext context)
    {
        _context = context;
        BlogRepository ??= new BlogRepository(context);
    }

    //public Task SaveChangesAsync(CancellationToken cs)
    //{
    //    return _context.SaveChangesAsync(cs);
    //}
    //public async Task<Result<List<BlogModel>>> GetBlogListAsync(int pageNo, int pageSize, CancellationToken cs)
    //{
    //    Result<List<BlogModel>> result;
    //    try
    //    {
    //        var query = _context.TblBlogs
    //        .Paginate(pageNo, pageSize);

    //        var lst = await query.Select(x => new BlogModel()
    //        {
    //            BlogId = x.BlogId,
    //            BlogTitle = x.BlogTitle,
    //            BlogAuthor = x.BlogAuthor,
    //            BlogContent = x.BlogContent,
    //        }).ToListAsync(cs);
    //        result = Result<List<BlogModel>>.Success(lst);
    //    }
    //    catch (Exception ex)
    //    {
    //        result = Result<List<BlogModel>>.Fail(ex);

    //    }
    //    return result;
    //}
}

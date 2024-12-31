using SMAdvancedC_DotNet.Database.Models;
using SMAdvancedC_DotNet.UnitOfWorkPattern.Persistance.Repositories;

namespace SMAdvancedC_DotNet.UnitOfWorkPattern.Persistance
{
    public class UnitOfWork : IUnitOfWork
    {
        internal readonly AppDbContext _context;
        public IBlogRepository BlogRepository { get; set; }

        public UnitOfWork(AppDbContext context)
        {
            _context = context;
            BlogRepository ??= new BlogRepository(context);
        }
    }
}

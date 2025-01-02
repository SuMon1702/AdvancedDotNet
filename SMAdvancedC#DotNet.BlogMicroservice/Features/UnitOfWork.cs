using SMAdvancedC_DotNet.Database.Models;
using SMAdvancedC_DotNet.GenericRepository.Persistance.Repositories;

namespace SMAdvancedC_DotNet.BlogMicroservice.Features
{
    public class UnitOfWork : IUnitOfWork
    {
        internal readonly AppDbContext _context;

        public UnitOfWork(AppDbContext context)
        {
            _context = context;
            BlogRepository ??= new BlogRepository(_context);
        }

        public IBlogRepository BlogRepository { get; set; }
    }
}

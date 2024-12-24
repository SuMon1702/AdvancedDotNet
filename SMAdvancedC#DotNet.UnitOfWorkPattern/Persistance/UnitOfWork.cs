using SMAdvancedC_DotNet.Database.Models;
using SMAdvancedC_DotNet.GenericRepository.Persistance.Repositories;

namespace SMAdvancedC_DotNet.UnitOfWorkPattern.Persistance
{
    public class UnitOfWork : IUnitOfWork
    {
        internal readonly AppDbContext _context;
        public IBlogRepository BlogRepository { get; set; }

        RepositoryPattern.Persistance.Repositories.IBlogRepository IUnitOfWork.BlogRepository => throw new NotImplementedException();

        public UnitOfWork(AppDbContext context)
        {
            _context = context;
            BlogRepository ??= new BlogRepository(context);
        }
    }
}

using SMAdvancedC_DotNet.GenericRepository.Persistance.Repositories;

namespace SMAdvancedC_DotNet.BlogMicroservice.Features
{
    public interface IUnitOfWork
    {
        IBlogRepository BlogRepository { get; }
    }
}

using SMAdvancedC_DotNet.RepositoryPattern.Persistance.Repositories;

namespace SMAdvancedC_DotNet.UnitOfWorkPattern.Persistance
{
    public interface IUnitOfWork
    {
        IBlogRepository BlogRepository { get; }
    }
}

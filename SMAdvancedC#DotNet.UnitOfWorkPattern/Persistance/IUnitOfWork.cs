using SMAdvancedC_DotNet.UnitOfWorkPattern.Persistance.Repositories;

namespace SMAdvancedC_DotNet.UnitOfWorkPattern.Persistance
{
    public interface IUnitOfWork
    {
        IBlogRepository BlogRepository { get; }
    }
}

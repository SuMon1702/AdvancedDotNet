using SMAdvancedC_DotNet.UnitOfWorkPattern.Persistence.Repositories;

namespace SMAdvancedC_DotNet.UnitOfWorkPattern.Persistence;

public interface IUnitOfWork
{
    IBlogRepository BlogRepository { get; }


}

using Infrastructure.Repositories;

namespace Infrastructure.UnitOfWorks
{
    public interface IApplicationUnitOfWork : IUnitOfWork
    {
        IBookRepository Books { get; }
    }
}
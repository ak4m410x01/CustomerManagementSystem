using CustomerManagementSystem.MVC.Application.Interfaces.Repositories;
using CustomerManagementSystem.MVC.Domain.Common.Abstracts;

namespace CustomerManagementSystem.MVC.Application.Interfaces.UnitOfWorks
{
    public interface IUnitOfWork : IAsyncDisposable
    {
        IRepository<T> Repository<T>() where T : BaseEntity;

        Task<int> SaveAsync();
    }
}
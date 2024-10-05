using CustomerManagementSystem.MVC.Application.Interfaces.Repositories;
using CustomerManagementSystem.MVC.Application.Interfaces.UnitOfWorks;
using CustomerManagementSystem.MVC.Domain.Common.Abstracts;
using CustomerManagementSystem.MVC.Persistence.DbContexts;
using CustomerManagementSystem.MVC.Persistence.Repositories;
using System.Collections.Concurrent;

namespace CustomerManagementSystem.MVC.Persistence.UnitOfWorks
{
    public class UnitOfWork : IUnitOfWork
    {
        #region Properties

        private readonly CustomerManagementSystemDbContext _context;

        private ConcurrentDictionary<string, object> _repositories;

        #endregion Properties

        #region Constructors

        public UnitOfWork(CustomerManagementSystemDbContext context)
        {
            _context = context;
            _repositories = new ConcurrentDictionary<string, object>();
        }

        #endregion Constructors

        #region Methods

        public IRepository<T> Repository<T>() where T : BaseEntity
        {
            string type = typeof(T).Name;

            Repository<T> repository = new(_context);

            return (IRepository<T>)_repositories.GetOrAdd(type, repository);
        }

        public async Task<int> SaveAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public async ValueTask DisposeAsync()
        {
            await _context.DisposeAsync();
        }

        #endregion Methods
    }
}
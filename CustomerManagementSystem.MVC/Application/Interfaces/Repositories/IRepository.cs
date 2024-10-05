using CustomerManagementSystem.MVC.Application.Interfaces.Specifications;
using CustomerManagementSystem.MVC.Domain.Common.Abstracts;
using Microsoft.EntityFrameworkCore.Storage;

namespace CustomerManagementSystem.MVC.Application.Interfaces.Repositories
{
    public interface IRepository<T> where T : BaseEntity
    {
        #region Get All

        Task<IQueryable<T>> GetAllAsync(ISpecification<T> specification, CancellationToken token = default);

        Task<IQueryable<T>> GetAllAsNoTrackingAsync(ISpecification<T> specification, CancellationToken token = default);

        #endregion Get All

        #region Find

        Task<T?> FindAsync(ISpecification<T> specification, CancellationToken token = default);

        Task<T?> FindAsNoTrackingAsync(ISpecification<T> specification, CancellationToken token = default);

        #endregion Find

        #region IsExists

        Task<bool> IsExistsAsync(ISpecification<T> specification, CancellationToken token = default);

        Task<bool> AnyAsync(ISpecification<T> specification, CancellationToken token = default);

        #endregion IsExists

        #region Add

        Task AddAsync(T entity, CancellationToken cancellationToke = default);

        Task AddRangeAsync(ICollection<T> entities, CancellationToken token = default);

        #endregion Add

        #region Update

        Task UpdateAsync(T entity, CancellationToken token = default);

        Task UpdateRangeAsync(ICollection<T> entities, CancellationToken token = default);

        #endregion Update

        #region Delete

        Task DeleteAsync(T entity, CancellationToken token = default);

        Task DeleteRangeAsync(ICollection<T> entities, CancellationToken token = default);

        #endregion Delete

        #region Save

        Task<int> SaveChangesAsync(CancellationToken token = default);

        #endregion Save

        #region Transaction

        Task<IDbContextTransaction> BeginTransactionAsync(CancellationToken token = default);

        Task CommitTransactionAsync(CancellationToken token = default);

        Task RollbackTransactionAsync(CancellationToken token = default);

        #endregion Transaction

        #region Attach

        Task AttachAsync(T entity, CancellationToken token = default);

        Task AttachRangeAsync(ICollection<T> entities, CancellationToken token = default);

        #endregion Attach
    }
}
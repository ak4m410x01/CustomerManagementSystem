using CustomerManagementSystem.MVC.Application.Interfaces.Repositories;
using CustomerManagementSystem.MVC.Application.Interfaces.Specifications;
using CustomerManagementSystem.MVC.Domain.Common.Abstracts;
using CustomerManagementSystem.MVC.Persistence.Specifications.Evaluations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore;
using CustomerManagementSystem.MVC.Persistence.DbContexts;

namespace CustomerManagementSystem.MVC.Persistence.Repositories
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
        #region Properties

        protected readonly CustomerManagementSystemDbContext _context;

        #endregion Properties

        #region Constructors

        public Repository(CustomerManagementSystemDbContext context)
        {
            _context = context;
        }

        #endregion Constructors

        #region Method

        protected virtual DbSet<T> GetDbSet()
        {
            return _context.Set<T>();
        }

        protected virtual IQueryable<T> GetQuery(ISpecification<T> specification)
        {
            return SpecificationEvaluator<T>.GetQuery(GetDbSet(), specification);
        }

        #region Get All

        public virtual Task<IQueryable<T>> GetAllAsync(ISpecification<T> specification, CancellationToken token = default)
        {
            return Task.FromResult(GetQuery(specification));
        }

        public virtual Task<IQueryable<T>> GetAllAsNoTrackingAsync(ISpecification<T> specification, CancellationToken token = default)
        {
            return Task.FromResult(GetQuery(specification).AsNoTracking());
        }

        #endregion Get All

        #region Find

        public virtual Task<T?> FindAsync(ISpecification<T> specification, CancellationToken token = default)
        {
            return GetQuery(specification).FirstOrDefaultAsync(token);
        }

        public virtual Task<T?> FindAsNoTrackingAsync(ISpecification<T> specification, CancellationToken token = default)
        {
            return GetQuery(specification).AsNoTracking().FirstOrDefaultAsync(token);
        }

        #endregion Find

        #region IsExists

        public virtual async Task<bool> IsExistsAsync(ISpecification<T> specification, CancellationToken token = default)
        {
            return (await GetQuery(specification).AsNoTracking().FirstOrDefaultAsync(token)) != null;
        }

        public virtual async Task<bool> AnyAsync(ISpecification<T> specification, CancellationToken token = default)
        {
            return (await GetQuery(specification).AsNoTracking().AnyAsync(token));
        }

        #endregion IsExists

        #region Add

        public virtual async Task AddAsync(T entity, CancellationToken token = default)
        {
            await GetDbSet().AddAsync(entity, token);
            await SaveChangesAsync(token);
        }

        public virtual async Task AddRangeAsync(ICollection<T> entities, CancellationToken token = default)
        {
            await GetDbSet().AddRangeAsync(entities, token);
            await SaveChangesAsync(token);
        }

        #endregion Add

        #region Update

        public virtual async Task UpdateAsync(T entity, CancellationToken token = default)
        {
            GetDbSet().Update(entity);
            await SaveChangesAsync(token);
        }

        public virtual async Task UpdateRangeAsync(ICollection<T> entities, CancellationToken token = default)
        {
            GetDbSet().UpdateRange(entities);
            await SaveChangesAsync(token);
        }

        #endregion Update

        #region Delete

        public virtual async Task DeleteAsync(T entity, CancellationToken token = default)
        {
            GetDbSet().Remove(entity);
            await SaveChangesAsync(token);
        }

        public virtual async Task DeleteRangeAsync(ICollection<T> entities, CancellationToken token = default)
        {
            GetDbSet().RemoveRange(entities);
            await SaveChangesAsync(token);
        }

        #endregion Delete

        #region Save

        public virtual async Task<int> SaveChangesAsync(CancellationToken token = default)
        {
            return await _context.SaveChangesAsync(token);
        }

        #endregion Save

        #region Transaction

        public virtual async Task<IDbContextTransaction> BeginTransactionAsync(CancellationToken token = default)
        {
            return await _context.Database.BeginTransactionAsync(token);
        }

        public virtual async Task CommitTransactionAsync(CancellationToken token = default)
        {
            await _context.Database.CommitTransactionAsync(token);
        }

        public virtual async Task RollbackTransactionAsync(CancellationToken token = default)
        {
            await _context.Database.RollbackTransactionAsync(token);
        }

        #endregion Transaction

        #region Attach

        public virtual async Task AttachAsync(T entity, CancellationToken token = default)
        {
            GetDbSet().Attach(entity);
            await SaveChangesAsync(token);
        }

        public virtual async Task AttachRangeAsync(ICollection<T> entities, CancellationToken token = default)
        {
            GetDbSet().AttachRange(entities);
            await SaveChangesAsync(token);
        }

        #endregion Attach

        #endregion Method
    }
}
using CustomerManagementSystem.MVC.Application.Interfaces.Specifications;
using CustomerManagementSystem.MVC.Domain.Common.Abstracts;
using Microsoft.EntityFrameworkCore;

namespace CustomerManagementSystem.MVC.Persistence.Specifications.Evaluations
{
    public static class SpecificationEvaluator<T> where T : BaseEntity
    {
        #region Methods

        public static string GetQueryString(IQueryable<T> query)
        {
            return query.ToQueryString();
        }

        public static IQueryable<T> GetQuery(IQueryable<T> inputQuery, ISpecification<T> specification)
        {
            IQueryable<T> query = inputQuery;

            query = AddCriteriaExpressions(query, specification);

            query = AddIncludeExpressions(query, specification);

            query = AddOrderByExpression(query, specification);

            return query;
        }

        private static IQueryable<T> AddCriteriaExpressions(IQueryable<T> inputQuery, ISpecification<T> specification)
        {
            foreach (var criteria in specification.CriteriaExpressions)
            {
                inputQuery = inputQuery.Where(criteria);
            }
            return inputQuery;
        }

        private static IQueryable<T> AddIncludeExpressions(IQueryable<T> inputQuery, ISpecification<T> specification)
        {
            return specification.IncludeExpressions
                                .Aggregate(inputQuery,
                                     (current, expression) => current.Include(expression));
        }

        private static IQueryable<T> AddOrderByExpression(IQueryable<T> inputQuery, ISpecification<T> specification)
        {
            foreach (var (expression, isAscending) in specification.OrderByExpressions)
            {
                inputQuery = isAscending ? inputQuery.OrderBy(expression) : inputQuery.OrderByDescending(expression);
            }
            return inputQuery;
        }

        #endregion Methods
    }
}
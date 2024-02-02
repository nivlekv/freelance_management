using HotelLiveModel.Enum;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace HotelLiveDAL
{    public interface IRepositoryBase<T>
    {
        Task<T> Get();
        Task<T> Get(long id);
        Task<T> GetByCondition(Expression<Func<T, bool>> expression);
        Task<T> GetByCondition(Expression<Func<T, bool>> expression, string sorting, SortEnum sortType);
        Task<T> GetByCondition(List<Expression<Func<T, bool>>> expression);
        IEnumerable<T> GetAll();
        IEnumerable<T> GetAllSort(string sorting, SortEnum sortType);
        IEnumerable<T> GetAllByCondition(Expression<Func<T, bool>> expression);
        IQueryable<T> GetAllByConditionQuery(Expression<Func<T, bool>> expression);
        IQueryable<T> GetAllByCondition(List<Expression<Func<T, bool>>> expression);
        IEnumerable<T> GetAllByConditionSort(List<Expression<Func<T, bool>>> expression, string sorting, SortEnum sortType);
        IEnumerable<T> GetAllByPage(int page, int size, Expression<Func<T, bool>> expression, out long total);
        IEnumerable<T> GetAllByPageSortingEnmerable(int page, int size, List<Expression<Func<T, bool>>> expression, string sorting, SortEnum sortType, out long total);
        IEnumerable<T> GetAllByLimit(int limit, Expression<Func<T, bool>> expression);
        IQueryable<T> GetAllByPageSorting(int page, int size, List<Expression<Func<T, bool>>> expression, string sorting, SortEnum sortType, out long total);
        IEnumerable<T> GetAllByLimitSorting(int limit, Expression<Func<T, bool>> expression, string sorting, int sortType);
        Task<EntityEntry> CreateAsync(T entity);
        EntityEntry Update(T entity);
        EntityEntry Delete(T entity);
        Task<int> Save();
        Task<decimal> Sum(Expression<Func<T, decimal>> expression);
        Task<decimal> Sum(Expression<Func<T, bool>> filter, Expression<Func<T, decimal>> expression);
    }
}

namespace FreelancersDal
{
    public class RepositoryBase<T> : IRepositoryBase<T> where T : MySqlEntity
    {
        protected RepositoryContext _repositoryContext { get; set; }

        public RepositoryBase(RepositoryContext repositoryContext)
        {
            _repositoryContext = repositoryContext;
            //_repositoryContext.Database.EnsureCreated();
        }

        public async Task<T> Get()
        {
            try
            {
                return await _repositoryContext.Set<T>().FirstOrDefaultAsync();
            }
            catch
            {
                return null;
            }
        }
        public async Task<T> Get(long id)
        {
            return await _repositoryContext.Set<T>().Where(p => p.ID == id).FirstOrDefaultAsync();
        }

        public async Task<T> GetByCondition(Expression<Func<T, bool>> expression)
        {
            return await _repositoryContext.Set<T>().Where(expression).FirstOrDefaultAsync();
        }
        public async Task<T> GetByCondition(List<Expression<Func<T, bool>>> expression)
        {
            var result = _repositoryContext.Set<T>().AsNoTracking();

            foreach (var es in expression)
            {
                result = result.Where(es);
            }

            return await result.FirstOrDefaultAsync(); // Use AsNoTracking() to detach loaded entities and free up space for update.
        }
        public async Task<T> GetByCondition(Expression<Func<T, bool>> expression, string sorting, SortEnum sortType)
        {
            var result = await _repositoryContext.Set<T>().Where(expression).OrderBy(sorting + " " + sortType.ToString()).FirstOrDefaultAsync();

            return result;
        }

        public IEnumerable<T> GetAll()
        {
            return _repositoryContext.Set<T>().AsNoTracking(); // Use AsNoTracking() to detach loaded entities and free up space for update.
        }
        public IEnumerable<T> GetAllSort(string sorting, SortEnum sortType)
        {
            var result = _repositoryContext.Set<T>().AsNoTracking();
            return result.OrderBy(sorting + " " + sortType.ToString());
        }

        public IEnumerable<T> GetAllByCondition(Expression<Func<T, bool>> expression)
        {
            return _repositoryContext.Set<T>().Where(expression).AsNoTracking(); // Use AsNoTracking() to detach loaded entities and free up space for update.
        }
        public IQueryable<T> GetAllByConditionQuery(Expression<Func<T, bool>> expression)
        {
            return _repositoryContext.Set<T>().Where(expression).AsNoTracking(); // Use AsNoTracking() to detach loaded entities and free up space for update.
        }
        public IQueryable<T> GetAllByCondition(List<Expression<Func<T, bool>>> expression)
        {
            var result = _repositoryContext.Set<T>().AsNoTracking();

            foreach (var es in expression)
            {
                result = result.Where(es);
            }
            return result;
        }

        public IEnumerable<T> GetAllByConditionSort(List<Expression<Func<T, bool>>> expression, string sorting, SortEnum sortType)
        {
            var result = _repositoryContext.Set<T>().AsNoTracking();

            foreach (var es in expression)
            {
                result = result.Where(es);
            }

            return result.OrderBy(sorting + " " + sortType.ToString()); // Use AsNoTracking() to detach loaded entities and free up space for update.
        }

        public IEnumerable<T> GetAllByPage(int page, int size, Expression<Func<T, bool>> expression, out long total)
        {
            var result = _repositoryContext.Set<T>().Where(expression);
            total = result.Count();
            var list = result.Skip((page - 1) * size).Take(size);
            return list.AsNoTracking();
        }
        public IEnumerable<T> GetAllByLimit(int limit, Expression<Func<T, bool>> expression)
        {
            var result = _repositoryContext.Set<T>().Where(expression);
            var list = result.Take(limit);
            return list.AsNoTracking();
        }

        public IQueryable<T> GetAllByPageSorting(int page, int size, List<Expression<Func<T, bool>>> expression, string sorting, SortEnum sortType, out long total)
        {
            var propertyInfo = typeof(T).GetProperty(sorting);

            var result = _repositoryContext.Set<T>().AsNoTracking();

            foreach(var es in expression)
            {
                result = result.Where(es);
            }
            result = result.OrderBy(sorting + " " + sortType.ToString());
            total = result.Count();
            var list = result.Skip((page - 1) * size).Take(size);
            return list;
        }
        public IEnumerable<T> GetAllByPageSortingEnmerable(int page, int size, List<Expression<Func<T, bool>>> expression, string sorting, SortEnum sortType, out long total)
        {
            var propertyInfo = typeof(T).GetProperty(sorting);

            var result = _repositoryContext.Set<T>().AsNoTracking();

            foreach (var es in expression)
            {
                result = result.Where(es);
            }
            result = result.OrderBy(sorting + " " + sortType.ToString());
            total = result.Count();
            var list = result.Skip((page - 1) * size).Take(size);
            return list;
        }

        public IEnumerable<T> GetAllByLimitSorting(int limit, Expression<Func<T, bool>> expression, string sorting, int sortType)
        {
            var propertyInfo = typeof(T).GetProperty(sorting);

            var result = (sortType == 0) ? _repositoryContext.Set<T>().AsNoTracking().Where(expression).OrderBy(x => propertyInfo.GetValue(x, null)) : _repositoryContext.Set<T>().AsNoTracking().Where(expression).OrderByDescending(x => propertyInfo.GetValue(x, null));
            var list = result.Take(limit);
            return list.AsNoTracking();
        }

        public async Task<decimal> Sum(Expression<Func<T, decimal>> expression)
        {
            var result = await _repositoryContext.Set<T>().AsNoTracking().SumAsync(expression);
            return result;
        }

        public async Task<decimal> Sum(Expression<Func<T, bool>> filter, Expression<Func<T, decimal>> expression)
        {
            var result = await _repositoryContext.Set<T>().AsNoTracking().Where(filter).SumAsync(expression);
            return result;
        }

        public async Task<EntityEntry> CreateAsync(T entity)
        {
            try
            {
                if (entity.CreateBy == null || entity.CreateBy == "")
                {
                    entity.CreateBy = GetDefaultUser();
                }
                entity.CreateDate = DateTime.Now;

            }
            catch
            {

            }

            return await _repositoryContext.Set<T>().AddAsync(entity);
        }

        public EntityEntry Update(T entity)
        {
            if (entity.ModifiedBy == null || entity.ModifiedBy == "")
            {
                entity.ModifiedBy = GetDefaultUser();
            }

            return _repositoryContext.Set<T>().Update(entity);
        }

        public EntityEntry Delete(T entity)
        {
            return _repositoryContext.Set<T>().Remove(entity);
        }

        public async Task<int> Save()
        {
            return await _repositoryContext.SaveChangesAsync();
        }



        // Private 
        private string GetDefaultUser()
        {
            return "SAdmin";
        }
    }
}

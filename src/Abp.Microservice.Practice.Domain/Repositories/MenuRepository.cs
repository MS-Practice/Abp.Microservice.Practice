using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Abp.Microservice.Practice.Domain.Entities;

namespace Abp.Microservice.Practice.Domain.Repositories
{
    public class MenuRepository : IMenuRepository
    {
        public Type ElementType => throw new NotImplementedException();

        public Expression Expression => throw new NotImplementedException();

        public IQueryProvider Provider => throw new NotImplementedException();

        public void Delete(Expression<Func<Menu, bool>> predicate, bool autoSave = false)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id, bool autoSave = false)
        {
            throw new NotImplementedException();
        }

        public void Delete(Menu entity, bool autoSave = false)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Expression<Func<Menu, bool>> predicate, bool autoSave = false, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id, bool autoSave = false, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Menu entity, bool autoSave = false, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Menu Find(int id, bool includeDetails = true)
        {
            throw new NotImplementedException();
        }

        public Task<Menu> FindAsync(int id, bool includeDetails = true, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Menu Get(int id, bool includeDetails = true)
        {
            throw new NotImplementedException();
        }

        public Task<Menu> GetAsync(int id, bool includeDetails = true, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public long GetCount()
        {
            throw new NotImplementedException();
        }

        public Task<long> GetCountAsync(CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<Menu> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public List<Menu> GetList(bool includeDetails = false)
        {
            throw new NotImplementedException();
        }

        public Task<List<Menu>> GetListAsync(bool includeDetails = false, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Menu Insert(Menu entity, bool autoSave = false)
        {
            throw new NotImplementedException();
        }

        public Task<Menu> InsertAsync(Menu entity, bool autoSave = false, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Menu Update(Menu entity, bool autoSave = false)
        {
            throw new NotImplementedException();
        }

        public Task<Menu> UpdateAsync(Menu entity, bool autoSave = false, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Menu> WithDetails()
        {
            throw new NotImplementedException();
        }

        public IQueryable<Menu> WithDetails(params Expression<Func<Menu, object>>[] propertySelectors)
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}

using ContactList.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ContactList.Application.Interfaces.Repositories
{
    public interface IGenericRepository<T> where T:BaseEntity
    {
        Task<T> AddAsync(T entity);
        Task<T> GetByIdAsync(Guid id);
        Task<T> UpdateAsync(T entity);
        Task<bool> DeleteAsync(Guid id);

        Task<List<T>> GetAllAsync(Expression<Func<T, bool>> predicate = null, params Expression<Func<T, object>>[] includeProperties);
    }
}

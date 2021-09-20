using ContactList.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactList.Application.Interfaces.Repositories
{
    public interface IGenericRepository<T> where T:BaseEntity
    {
        Task<T> AddAsync(T entity);
        Task<T> GetByIdAsync(Guid id);
        Task<T> UpdateAsync(T entity);
        Task<T> DeleteAsync(Guid id);

        Task<List<T>> GetAll();
    }
}

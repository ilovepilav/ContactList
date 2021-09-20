using ContactList.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactList.Application.Interfaces.Repositories
{
    public interface IPersonRepository:IGenericRepository<Person>
    {
    }
}

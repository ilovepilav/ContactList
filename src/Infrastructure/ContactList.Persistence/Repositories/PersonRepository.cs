using ContactList.Application.Interfaces.Repositories;
using ContactList.Domain.Entities;
using ContactList.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactList.Persistence.Repositories
{
    public class PersonRepository:GenericRepository<Person>, IPersonRepository
    {
        public PersonRepository(ApplicationDbContext dbContext):base(dbContext)
        {

        }
    }
}

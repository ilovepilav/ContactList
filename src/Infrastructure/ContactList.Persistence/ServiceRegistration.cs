using ContactList.Application.Interfaces.Repositories;
using ContactList.Persistence.Context;
using ContactList.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactList.Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceRegistration(this IServiceCollection services)
        {
            services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer("Server=localhost;Database=ContactListDb;Integrated Security=True"));

            services.AddScoped<IPersonRepository, PersonRepository>();
            services.AddScoped<IContactRepository, ContactRepository>();
        }
    }
}

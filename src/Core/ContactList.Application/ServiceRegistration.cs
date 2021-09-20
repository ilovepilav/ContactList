using ContactList.Application.Mapping;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ContactList.Application
{
    public static class ServiceRegistration
    {
        public static void AddApplicationRegistration(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(PersonProfile), typeof(ContactProfile));
            services.AddMediatR(Assembly.GetExecutingAssembly());
        }
    }
}

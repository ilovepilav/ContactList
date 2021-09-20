using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactList.Application.Features.Commands.ContactCommands.UpdateContact
{
    public class UpdateContactCommand:IRequest<bool>
    {
        public Guid Id { get; set; }
        public string ContactName { get; set; }
        public string PhoneNumber { get; set; }
    }
}

using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactList.Application.Features.Commands.ContactCommands.CreateContact
{
    public class CreateContactCommand:IRequest<bool>
    {
        public Guid PersonId { get; set; }
        public string ContactName { get; set; }
        public string PhoneNumber { get; set; }
    }
}

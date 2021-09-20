using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactList.Application.Features.Commands.PersonCommands.DeletePerson
{
    public class DeletePersonCommand:IRequest<bool>
    {
        public Guid Id { get; set; }
    }
}

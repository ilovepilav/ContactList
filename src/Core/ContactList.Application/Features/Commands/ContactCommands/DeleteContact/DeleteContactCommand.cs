using MediatR;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactList.Application.Features.Commands.ContactCommands.DeleteContact
{
    public class DeleteContactCommand:IRequest<bool>
    {
        [Required]
        public Guid Id { get; set; }
    }
}

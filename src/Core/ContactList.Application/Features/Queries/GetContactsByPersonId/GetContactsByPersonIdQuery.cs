using ContactList.Application.Dtos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactList.Application.Features.Queries.GetContactsByPersonId
{
    public class GetContactsByPersonIdQuery:IRequest<List<ContactViewDto>>
    {
        public Guid PersonId { get; set; }
    }
}

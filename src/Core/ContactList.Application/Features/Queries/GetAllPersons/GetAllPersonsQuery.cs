using ContactList.Application.Dtos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactList.Application.Features.Queries.GetAllPersons
{
    public class GetAllPersonsQuery:IRequest<List<PersonViewDto>>
    {
    }
}

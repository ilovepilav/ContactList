using AutoMapper;
using ContactList.Application.Dtos;
using ContactList.Application.Interfaces.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ContactList.Application.Features.Queries.GetAllPersons
{
    public class GetAllPersonsQueryHandler : IRequestHandler<GetAllPersonsQuery, List<PersonViewDto>>
    {
        private readonly IPersonRepository personRepository;
        private readonly IMapper mapper;

        public GetAllPersonsQueryHandler(IPersonRepository personRepository, IMapper mapper)
        {
            this.personRepository = personRepository;
            this.mapper = mapper;
        }

        public async Task<List<PersonViewDto>> Handle(GetAllPersonsQuery request, CancellationToken cancellationToken)
        {
            var persons = await personRepository.GetAllAsync();
            var dtos = mapper.Map<List<PersonViewDto>>(persons);

            return dtos;
        }
    }
}

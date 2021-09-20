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

namespace ContactList.Application.Features.Queries.GetPersonById
{
    public class GetPersonByIdQueryHandler : IRequestHandler<GetPersonByIdQuery, PersonViewDto>
    {
        private readonly IPersonRepository personRepository;
        private readonly IMapper mapper;

        public GetPersonByIdQueryHandler(IPersonRepository personRepository, IMapper mapper)
        {
            this.personRepository = personRepository;
            this.mapper = mapper;
        }

        public async Task<PersonViewDto> Handle(GetPersonByIdQuery request, CancellationToken cancellationToken)
        {
            var person = await personRepository.GetByIdAsync(request.Id);
            var dto = mapper.Map<PersonViewDto>(person);

            return dto;
        }
    }
}

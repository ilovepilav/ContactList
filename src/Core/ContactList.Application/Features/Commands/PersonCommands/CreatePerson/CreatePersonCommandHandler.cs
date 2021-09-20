using AutoMapper;
using ContactList.Application.Interfaces.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ContactList.Application.Features.Commands.PersonCommands.CreatePerson
{
    public class CreatePersonCommandHandler : IRequestHandler<CreatePersonCommand, bool>
    {
        private readonly IPersonRepository personRepository;
        private readonly IMapper mapper;

        public CreatePersonCommandHandler(IPersonRepository personRepository, IMapper mapper)
        {
            this.personRepository = personRepository;
            this.mapper = mapper;
        }

        public async Task<bool> Handle(CreatePersonCommand request, CancellationToken cancellationToken)
        {
            var person = mapper.Map<Domain.Entities.Person>(request);
            await personRepository.AddAsync(person);

            return true;
        }
    }
}

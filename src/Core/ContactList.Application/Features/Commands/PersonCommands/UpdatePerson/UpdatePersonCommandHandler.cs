using AutoMapper;
using ContactList.Application.Interfaces.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ContactList.Application.Features.Commands.PersonCommands.UpdatePerson
{
    public class UpdatePersonCommandHandler : IRequestHandler<UpdatePersonCommand, bool>
    {
        private readonly IPersonRepository personRepository;
        private readonly IMapper mapper;

        public UpdatePersonCommandHandler(IPersonRepository personRepository, IMapper mapper)
        {
            this.personRepository = personRepository;
            this.mapper = mapper;
        }

        public async Task<bool> Handle(UpdatePersonCommand request, CancellationToken cancellationToken)
        {
            var person = await personRepository.GetByIdAsync(request.Id);
            mapper.Map(request, person);
            await personRepository.UpdateAsync(person);

            return true;
        }
    }
}

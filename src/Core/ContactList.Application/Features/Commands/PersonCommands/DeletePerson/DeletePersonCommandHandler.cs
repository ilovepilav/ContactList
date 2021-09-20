using ContactList.Application.Interfaces.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ContactList.Application.Features.Commands.PersonCommands.DeletePerson
{
    public class DeletePersonCommandHandler : IRequestHandler<DeletePersonCommand, bool>
    {
        private readonly IPersonRepository personRepository;

        public DeletePersonCommandHandler(IPersonRepository personRepository)
        {
            this.personRepository = personRepository;
        }

        public async Task<bool> Handle(DeletePersonCommand request, CancellationToken cancellationToken)
        {
            await personRepository.DeleteAsync(request.Id);

            return true;
        }
    }
}

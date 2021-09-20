using AutoMapper;
using ContactList.Application.Interfaces.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ContactList.Application.Features.Commands.ContactCommands.CreateContact
{
    public class CreateContactCommandHandler : IRequestHandler<CreateContactCommand, bool>
    {
        private readonly IContactRepository contactRepository;
        private readonly IMapper mapper;

        public CreateContactCommandHandler(IContactRepository contactRepository, IMapper mapper)
        {
            this.contactRepository = contactRepository;
            this.mapper = mapper;
        }

        public async Task<bool> Handle(CreateContactCommand request, CancellationToken cancellationToken)
        {
            var contact = mapper.Map<Domain.Entities.Contact>(request);
            await contactRepository.AddAsync(contact);

            return true;
        }
    }
}

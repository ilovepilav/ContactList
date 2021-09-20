using AutoMapper;
using ContactList.Application.Interfaces.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ContactList.Application.Features.Commands.ContactCommands.UpdateContact
{
    public class UpdateContactCommandHandler : IRequestHandler<UpdateContactCommand, bool>
    {
        private readonly IContactRepository contactRepository;
        private readonly IMapper mapper;

        public UpdateContactCommandHandler(IContactRepository contactRepository, IMapper mapper)
        {
            this.contactRepository = contactRepository;
            this.mapper = mapper;
        }

        public async Task<bool> Handle(UpdateContactCommand request, CancellationToken cancellationToken)
        {
            var contact = await contactRepository.GetByIdAsync(request.Id);
            mapper.Map(request, contact);
            await contactRepository.UpdateAsync(contact);
            return true;
        }
    }
}

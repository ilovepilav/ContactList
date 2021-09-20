﻿using ContactList.Application.Interfaces.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ContactList.Application.Features.Commands.ContactCommands.DeleteContact
{
    public class DeleteContactCommandHandler : IRequestHandler<DeleteContactCommand, bool>
    {
        private readonly IContactRepository contactRepository;

        public DeleteContactCommandHandler(IContactRepository contactRepository)
        {
            this.contactRepository = contactRepository;
        }


        public async Task<bool> Handle(DeleteContactCommand request, CancellationToken cancellationToken)
        {
            await contactRepository.DeleteAsync(request.Id);
            return true;
        }
    }
}

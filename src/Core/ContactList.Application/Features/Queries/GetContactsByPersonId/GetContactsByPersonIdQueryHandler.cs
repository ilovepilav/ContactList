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

namespace ContactList.Application.Features.Queries.GetContactsByPersonId
{
    public class GetContactsByPersonIdQueryHandler : IRequestHandler<GetContactsByPersonIdQuery, List<ContactViewDto>>
    {
        private readonly IContactRepository contactRepository;
        private readonly IMapper mapper;

        public GetContactsByPersonIdQueryHandler(IContactRepository contactRepository, IMapper mapper)
        {
            this.contactRepository = contactRepository;
            this.mapper = mapper;
        }

        public async Task<List<ContactViewDto>> Handle(GetContactsByPersonIdQuery request, CancellationToken cancellationToken)
        {
            var contacts = await contactRepository.GetAllAsync(c => c.PersonId == request.PersonId);
            var dto = mapper.Map<List<ContactViewDto>>(contacts);

            return dto;
        }
    }
}

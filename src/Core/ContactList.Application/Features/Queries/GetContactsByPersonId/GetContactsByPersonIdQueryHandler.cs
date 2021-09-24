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
        private readonly IContactRepository _contactRepository;
        private readonly IMapper _mapper;

        public GetContactsByPersonIdQueryHandler(IContactRepository contactRepository, IMapper mapper)
        {
            _contactRepository = contactRepository;
            _mapper = mapper;
        }

        public async Task<List<ContactViewDto>> Handle(GetContactsByPersonIdQuery request, CancellationToken cancellationToken)
        {
            var contacts = await _contactRepository.GetAllAsync(c => c.PersonId == request.PersonId);
            var dto = _mapper.Map<List<ContactViewDto>>(contacts);

            return dto;
        }
    }
}

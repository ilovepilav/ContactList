using AutoMapper;
using ContactList.Application.Features.Commands.ContactCommands.CreateContact;
using ContactList.Application.Features.Commands.ContactCommands.UpdateContact;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactList.Application.Mapping
{
    public class ContactProfile:Profile
    {
        public ContactProfile()
        {
            CreateMap<Domain.Entities.Contact, Dtos.ContactViewDto>().ReverseMap();
            CreateMap<Domain.Entities.Contact, CreateContactCommand>().ReverseMap();
            CreateMap<Domain.Entities.Contact, UpdateContactCommand>().ReverseMap();
        }
    }
}

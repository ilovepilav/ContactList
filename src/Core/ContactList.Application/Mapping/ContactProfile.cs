using AutoMapper;
using ContactList.Application.Dtos;
using ContactList.Application.Features.Commands.ContactCommands.CreateContact;
using ContactList.Application.Features.Commands.ContactCommands.UpdateContact;
using ContactList.Domain.Entities;
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
            CreateMap<Contact, ContactViewDto>().ReverseMap();
            CreateMap<Contact, CreateContactCommand>().ReverseMap();
            CreateMap<Contact, UpdateContactCommand>().ReverseMap();
            CreateMap<ContactViewDto, UpdateContactCommand>().ReverseMap();
        }
    }
}

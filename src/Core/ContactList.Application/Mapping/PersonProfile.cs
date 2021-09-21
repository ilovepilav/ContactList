using AutoMapper;
using ContactList.Application.Dtos;
using ContactList.Application.Features.Commands.PersonCommands.CreatePerson;
using ContactList.Application.Features.Commands.PersonCommands.UpdatePerson;
using ContactList.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactList.Application.Mapping
{
    public class PersonProfile:Profile
    {
        public PersonProfile()
        {
            CreateMap<Person, PersonViewDto>().ReverseMap();
            CreateMap<Person, UpdatePersonCommand>().ReverseMap();
            CreateMap<Person, CreatePersonCommand>().ReverseMap();
        }
    }
}

using AutoMapper;
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
            CreateMap<Domain.Entities.Person, Dtos.PersonViewDto>().ReverseMap();
        }
    }
}

using System;
using AutoMapper;
using colourapiaugtwentyone.Dtos;
using colourapiaugtwentyone.Models;

namespace colourapiaugtwentyone.Mappings
{
    public class Maps : Profile
    {
        public Maps()
        {
            CreateMap<Colour, ColourDto>().ReverseMap();
        }
    }
}

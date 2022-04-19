using AutoMapper;
using MyProject.DTOs.UserDTOs;
using MyProject.DTOs.FlightDTOs;
using MyProject.DTOs.FromCityDTOs;
using MyProject.DTOs.ToCityDTOs;
using MyProject.Models;
using MyProject.DTOs.TicketDTOs;

namespace MyProject.Utility
{
    public class Automapper:Profile
    {
        public Automapper()
        {
            CreateMap<UserToAddDTO, User>();
            CreateMap<User, UserToListDTO>();
            CreateMap<UserToUpdateDTO, User>();

            CreateMap<FlightToAddDTO, Flight>().ReverseMap();
            CreateMap<Flight,FlightToListDTO>().ReverseMap();
            CreateMap<FlightToUpdateDTO, Flight>().ReverseMap();

            CreateMap<FromCityToAddDTO, FromCity>().ReverseMap();
            CreateMap<FromCity,FromCityToListDTO>().ReverseMap();
            CreateMap<FromCityToUpdateDTO, FromCity>().ReverseMap();

            CreateMap<ToCityAddDTO, ToCity>().ReverseMap();
            CreateMap<ToCity,ToCityToListDTO>().ReverseMap();
            CreateMap<ToCityToUpdateDTO, ToCity>().ReverseMap();

            CreateMap<TicketToAddDTO, Ticket>().ReverseMap();
            CreateMap<Ticket, TicketToListDTO>().ReverseMap();
        }
    }
}

using AutoMapper;
using FilmesApi.Data.Dtos.CinemaDTOs;
using FilmesApi.Data.Dtos.EnderecoDTOs;
using FilmesApi.Models;

namespace FilmesApi.Profiles
{
    public class CinemaProfile : Profile
    {
        public CinemaProfile()
        {
            CreateMap<CreateCinemaDTO, Cinema>();
            CreateMap<Cinema, ReadCinemaDTO>()
                .ForMember(cinemaDto => cinemaDto.Endereco, 
                    opt=>opt.MapFrom(cinema=>cinema.Endereco));
            CreateMap<UpdateCinemaDTO, Cinema>();
        }   
    }
}

﻿using AutoMapper;
using FilmesApi.Data.Dtos.EnderecoDTOs;
using FilmesApi.Models;

namespace FilmesApi.Profiles
{
    public class EnderecoProfile : Profile
    {
        public EnderecoProfile()
        {
            CreateMap<CreateEnderecoDTO, Endereco>();
            CreateMap<UpdateEnderecoDTO, Endereco>();
            CreateMap<Endereco, ReadEnderecoDTO>();
        }
    }
}
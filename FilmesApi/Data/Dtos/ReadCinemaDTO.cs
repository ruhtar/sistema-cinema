﻿using System.ComponentModel.DataAnnotations;

namespace FilmesApi.Data.Dtos
{
    public class ReadCinemaDTO
    {
        public int Id { get; set; }

        public string Nome { get; set; }
    }
}
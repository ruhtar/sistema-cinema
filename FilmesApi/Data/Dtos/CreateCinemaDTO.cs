using System.ComponentModel.DataAnnotations;

namespace FilmesApi.Data.Dtos
{
    public class CreateCinemaDTO
    {
        [Required(ErrorMessage = "O campo de nome precisa ser preenchido.")]
        public string Nome { get; set; }
    }
}

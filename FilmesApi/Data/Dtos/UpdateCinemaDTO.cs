using System.ComponentModel.DataAnnotations;

namespace FilmesApi.Data.Dtos
{
    public class UpdateCinemaDTO
    {
        [Required(ErrorMessage = "O campo de nome precisa ser preenchido.")]
        public string Nome { get; set; }
    }
}

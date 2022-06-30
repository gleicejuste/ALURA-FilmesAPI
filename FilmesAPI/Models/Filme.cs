using System.ComponentModel.DataAnnotations;

namespace FilmesAPI.Models
{
    public class Filme
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório")]
        public string Titulo { get; set; }
        [Required(ErrorMessage = "Campo Obrigatório")]
        public string Diretor { get; set; }
        [StringLength(30, ErrorMessage = "Máximo 30 caracteres")]
        public string Genero { get; set; }
        [Range(1, 600, ErrorMessage = "Duração entre 1 e 600 minutos")]
        public int Duracao { get; set; }

    }
}

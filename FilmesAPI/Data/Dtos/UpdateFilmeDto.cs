using System.ComponentModel.DataAnnotations;

namespace FilmesAPI.Data.Dtos
{
    public class UpdateFilmeDto
    {
        [Required(ErrorMessage = "Campo obrigatório")]
        public string Titulo { get; set; }
        [Required(ErrorMessage = "Campo obrigatório")]
        public string Diretor { get; set; }
        [StringLength(30, ErrorMessage = "Máximo 30 caracteres")]
        public string Genero { get; set; }
        [Range(1, 600, ErrorMessage = "Valores entre 1 e 600 minutos")]
        public int Duracao { get; set; }
        public DateTime HoraDaConsulta { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;

namespace eipiai.Dominio.DTO
{

    public class LivrosDTO
    {
        [Required(ErrorMessage = "Obrigatório")]
        public string titulo { get; set; } = string.Empty;
        [Required(ErrorMessage = "Obrigatório")]
        public string autor { get; set; } = string.Empty;
        [Required(ErrorMessage = "Obrigatório")]
        public string genero { get; set; } = string.Empty;
        public int ano_lancamento { get; set; }
    }
}
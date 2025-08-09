using System.ComponentModel.DataAnnotations;

namespace eipiai.Applications.ViewModel
{
    public class LivrosViewModel
    {
        [Required(ErrorMessage = "Obrigatório")]
        public string Titulo { get; set; } = string.Empty;

        [Required(ErrorMessage = "Obrigatório")]
        public string Autor { get; set; } = string.Empty;

        [Required(ErrorMessage = "Obrigatório")]
        public string Genero { get; set; } = string.Empty;


        public int Ano_Lancamento { get; set; }

    }
}

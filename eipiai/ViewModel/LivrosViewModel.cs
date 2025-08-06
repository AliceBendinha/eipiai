using System.ComponentModel.DataAnnotations;

namespace eipiai.ViewModel
{
    public class LivrosViewModel
    {
        [Required]
        public string Titulo { get; set; }
        
        [Required]
        public string Autor { get; set; }
        
        [Required]
        public string Genero { get; set; }
        
        [Required]
        public int Ano_Lancamento { get; set; }

    }
}

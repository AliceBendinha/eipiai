using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eipiai.Dominio.Model
{
    [Table("livros")]


    public class Livros
    {
        [Key]
        public int id { get; private set; }

        [Required(ErrorMessage = "Obrigatório")]
        public string titulo { get; private set; } = string.Empty;

        [Required(ErrorMessage = "Obrigatório")]
        public string autor { get; private set; } = string.Empty;

        [Required(ErrorMessage = "Obrigatório")]
        public string genero { get; private set; } = string.Empty;

        public int ano_lancamento { get; private set; }

        public Livros() { }

        //construtor
        public Livros(string titulo, string autor, string genero, int ano_lancamento)
        {

            this.titulo = titulo ?? throw new ArgumentNullException(nameof(titulo));
            this.autor = autor;
            this.genero = genero;
            this.ano_lancamento = ano_lancamento;
        }

        // Atualização de dados
        public void AtualizarDados(string titulo, string autor, string genero, int ano_lancamento)
        {
            this.titulo = titulo;
            this.autor = autor;
            this.genero = genero;
            this.ano_lancamento = ano_lancamento;
        }



    }
}

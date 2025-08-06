using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eipiai.Model
{
    [Table("livros")]


    public class Livros
    {
        [Key]
        public int id { get; set; }
        public string titulo { get; set; }
        public string autor { get; set; }
        public string genero { get; set; }
        public int ano_lancamento { get; set; }

        public Livros() { }


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

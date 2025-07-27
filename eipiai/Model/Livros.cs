using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eipiai.Model
{
    [Table("livros")]


    public class Livros
    {
        [Key]
       public int id {  get; private set; }
       public string titulo { get; private set; }
       public string autor { get; private set; }
       public string genero { get; private set; }
       public string ano_lancamento { get; private set; }

        public Livros(int id, string titulo, string autor, string genero, string ano_lancamento) 
        {
            this.id = id;
            this.titulo = titulo ?? throw new ArgumentNullException(nameof(titulo));
            this.autor = autor;
            this.genero = genero;
            this.ano_lancamento = ano_lancamento;
        }

        public Livros(string titulo, string autor, string genero, string ano_lancamento)
        {
            this.titulo = titulo;
            this.autor = autor;
            this.genero = genero;
            this.ano_lancamento = ano_lancamento;
        }
    }
}

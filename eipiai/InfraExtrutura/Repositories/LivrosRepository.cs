using eipiai.Dominio.DTO;
using eipiai.Dominio.Model;

namespace eipiai.InfraExtrutura.Repositories
{
    public class LivrosRepository : ILivrosRepository
    {
        private readonly ConnectionContext _context = new ConnectionContext();

        public void Add(Livros livros)
        {
            _context.Livross.Add(livros);
            _context.SaveChanges();
        }

        public List<LivrosDTO> Get()
        {
            return _context.Livross

            .Select(c =>
            new LivrosDTO()
            {
                titulo = c.titulo,
                autor = c.autor,
                genero = c.genero,
                ano_lancamento = c.ano_lancamento
            }).ToList();
        }

        public Livros GetById(int id)
        {
            var liv = _context.Livross.FirstOrDefault(l => l.id == id);
            if (liv == null)
                throw new KeyNotFoundException($"Livro com id {id} não encontrado.");
            return liv;
        }

        public void Update(Livros livros)
        {
            _context.Livross.Update(livros);
            _context.SaveChanges();
        }

        public void Delete(Livros livros)
        {
            _context.Livross.Remove(livros);
            _context.SaveChanges();
        }
    }
}

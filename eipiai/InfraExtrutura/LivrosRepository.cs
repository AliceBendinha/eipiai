using eipiai.Model;

namespace eipiai.InfraExtrutura
{
    public class LivrosRepository : ILivrosRepository
    {
        private readonly ConnectionContext _context = new ConnectionContext();

        public void Add(Livros livros)
        {
            _context.Livross.Add(livros);
            _context.SaveChanges();
        }

        public List<Livros> Get()
        {
            return _context.Livross.ToList();
        }

        public Livros GetById(int id)
        {
            return _context.Livross.FirstOrDefault(l => l.id == id);
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

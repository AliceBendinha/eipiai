using eipiai.Model;

namespace eipiai.InfraExtrutura
{
    public class LivrosRepository : IlivrosRepository
    {
        private ConnectionContext _context = new ConnectionContext();
        
        public void Add(Livros livros)
        {
            _context.Livross.Add(livros);
            _context.SaveChanges();
        }

        public List<Livros> Get()
        {
            return _context.Livross.ToList();
        }
    }
}

using eipiai.Dominio.DTO;

namespace eipiai.Dominio.Model
{
    public interface ILivrosRepository
    {
        void Add(Livros livros);

        List<LivrosDTO> Get();

        Livros GetById(int id);
        void Update(Livros livros);
        void Delete(Livros livros);
    }
}

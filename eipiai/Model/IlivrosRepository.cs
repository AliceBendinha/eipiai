namespace eipiai.Model
{
    public interface ILivrosRepository
    {
        void Add(Livros livros);

        List<Livros> Get();

        Livros GetById(int id);
        void Update(Livros livros);
        void Delete(Livros livros);
    }
}

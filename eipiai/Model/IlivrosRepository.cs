namespace eipiai.Model
{
    public interface ILivrosRepository
    {
        void Add(Livros livros);

        List<Livros> Get();
    }
}

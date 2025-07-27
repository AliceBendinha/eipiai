namespace eipiai.Model
{
    public interface IlivrosRepository
    {
        void Add(Livros livros);

        List<Livros> Get();
    }
}

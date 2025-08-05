using Microsoft.AspNetCore.Mvc;
using eipiai.Model;
using eipiai.ViewModel;

namespace eipiai.Controllers
{
    [ApiController]
    [Route("api/v2/livros")]

    public class LivrosController : ControllerBase
    {
        private readonly ILivrosRepository _livrosRepository;

        public LivrosController(ILivrosRepository livrosRepository)
        {
            _livrosRepository = livrosRepository ?? throw new ArgumentException(nameof(livrosRepository));
        }

        [HttpPost]
        public IActionResult Add(LivrosViewModel livrosView)
        {
            //Montando o caso de uso
            var livros = new Livros(livrosView.Titulo, livrosView.Autor, livrosView.Genero, livrosView.Ano_Lancamento);
                
            _livrosRepository.Add(livros);

             return Ok();
        }

        [HttpGet]
        public IActionResult Get()
        {
            var livroo = _livrosRepository.Get();

            return Ok(livroo);
        }
    }
}

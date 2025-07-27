using Microsoft.AspNetCore.Mvc;
using eipiai.Model;
using eipiai.ViewModel;

namespace eipiai.Controllers
{
    [ApiController]
    [Route("api/v1/livros")]

    public class LivrosController : ControllerBase
    {
        private IlivrosRepository _livrosRepository;

        public LivrosController(IlivrosRepository livrosRepository)
        {
            _livrosRepository = livrosRepository ?? throw new ArgumentException();
        }

        [HttpPost]
        public IActionResult Add(LivrosViewModel livrosView)
        {
            //Montando o caso de uso
            var livros = new Livros(livrosView.titulo, livrosView.autor, livrosView.genero, livrosView.ano_lancamento);
                
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

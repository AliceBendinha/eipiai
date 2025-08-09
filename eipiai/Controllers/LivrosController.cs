using eipiai.Applications.ViewModel;
using eipiai.Dominio.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace eipiai.Controllers
{
    [ApiController]
    [Route("api/v1/livros")]

    public class LivrosController : ControllerBase
    {
        private readonly ILivrosRepository _livrosRepository;

        public LivrosController(ILivrosRepository livrosRepository)
        {
            _livrosRepository = livrosRepository ?? throw new ArgumentException(nameof(livrosRepository));
        }

        //Criando um novo livro
        [Authorize] //protegendo a minha rota
        [HttpPost]
        public IActionResult Add([FromForm] LivrosViewModel livrosView)
        {

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            //Montando o caso de uso
            var livros = new Livros(
                livrosView.Titulo,
                livrosView.Autor,
                livrosView.Genero,
                livrosView.Ano_Lancamento
            );

            _livrosRepository.Add(livros);

            return Ok(new { mensagem = "Livro adicionado com sucesso" }); //200
        }

        //Litar todos os livros
        [Authorize] //protegendo a minha rota
        [HttpGet]
        public IActionResult Get()
        {
            var livroo = _livrosRepository.Get();

            return Ok(livroo); //200
        }
        [Authorize] //protegendo a minha rota
        [HttpPut("{id}")]
        public IActionResult Update([FromRoute] int id, [FromBody] LivrosViewModel livrosView)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState); //400

            var livroExistente = _livrosRepository.GetById(id);
            if (livroExistente == null)
                return NotFound(new { mensagem = "Livro não encontrado." }); //404

            // Atualiza os dados da entidade
            livroExistente.AtualizarDados(
            livrosView.Titulo,
            livrosView.Autor,
            livrosView.Genero,
            livrosView.Ano_Lancamento);

            // Salva a alteração no banco
            _livrosRepository.Update(livroExistente);

            return NoContent(); // 204 — sucesso sem corpo de resposta
        }

        //Remover um livro pelo ID
        [Authorize] //protegendo a minha rota 
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var livroN = _livrosRepository.GetById(id);
            if (livroN == null)
                return NotFound(new { mensagem = "Livro não encontrado" }); //404

            _livrosRepository.Delete(livroN);

            return NoContent(); // 204
        }

    }
}

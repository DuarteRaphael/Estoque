using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Estoque.Services.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutosController : ControllerBase
    {
        [HttpPost]
        public IActionResult Cadastrar()
        {
            return Ok();
        }
        [HttpPut]
        public IActionResult Atualizar()
        {
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult Excluir()
        {
            return Ok();
        }
        [HttpGet("{page}/{limit}")]
        public IActionResult BuscarTodos(int page, int limit)
        {
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult BusccarPorId(Guid id)
        {
            return Ok();
        }
    }
}

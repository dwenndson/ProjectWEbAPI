using Microsoft.AspNetCore.Mvc;
using projetos.Models;

namespace projetos.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProdutoController : ControllerBase
    {
        private static readonly Produto teste = new Produto(){
            Id = 1,
            Ativo = true,
            Nome = "Luigi",
            Quantidade = 1,
            Valor = 10
        };

        [HttpGet]
        public IActionResult ok(){
            return Ok("OK");
        }
        [HttpGet]
        [Route("produto")]
        public IActionResult ProdutoTeste(){
                return new OkObjectResult(teste);
        }
    }
}
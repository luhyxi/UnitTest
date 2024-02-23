using Microsoft.AspNetCore.Mvc;

namespace UnitTest.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PalavrasPorTamanhoController : ControllerBase
    {
        private readonly ILogger<PalavrasPorTamanhoController> _logger;

        public PalavrasPorTamanhoController(ILogger<PalavrasPorTamanhoController> logger)
        {
            _logger = logger;
        }

        [HttpPost]
        public ActionResult<IEnumerable<PalavrasPorTamanho>> Post(string[] palavras)
        {
            var palavrasNovas = new PalavrasPorTamanho();

            var result = palavrasNovas.SelecionarPalavras(palavras.ToList());
            
            return Ok(result);
        }
    }
}

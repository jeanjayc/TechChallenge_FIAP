using Microsoft.AspNetCore.Mvc;
using TechChallenge_FIAP_API.Application.Interface;

namespace TechChallenge_FIAP_API.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class PortalInvestimentosController : ControllerBase
    {
        private readonly IInvestimentoService _investimentoService;

        public PortalInvestimentosController(IInvestimentoService investimentoService)
        {
            _investimentoService = investimentoService;
        }

        [HttpGet]
        public async Task<IActionResult> ObterAcaoPorNome(string nome)
        {
            var result = await _investimentoService.ObterDadosAtivoPorNome(nome);
            return Ok(result);
        }

        [HttpGet]
        public async Task<IActionResult> ObterListaAtivos()
        {
            var result = await _investimentoService.ObterListaAtivos();
            return Ok(result);
        }

    }
}

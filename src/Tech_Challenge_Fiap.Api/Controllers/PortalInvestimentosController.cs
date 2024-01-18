using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using TechChallenge_FIAP_API.Application.Interface;
using TechChallenge_FIAP_API.Domain.Entities;

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
            var resultadoRequisicao = await _investimentoService.ObterDadosAtivoPorNome(nome);
            var result = JsonConvert.DeserializeObject<DadosAtivo>(resultadoRequisicao.Content);
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

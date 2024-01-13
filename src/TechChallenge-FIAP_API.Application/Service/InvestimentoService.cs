using Microsoft.Extensions.Configuration;
using TechChallenge_FIAP_API.Application.Interface;
using TechChallenge_FIAP_API.Domain.Entities;

namespace TechChallenge_FIAP_API.Application.Service
{
    public class InvestimentoService : IInvestimentoService
    {
        private readonly IConfiguration _configuration;
        public Task<DadosAtivo> ObterDadosAtivo(string nomeAtivo)
        {
            throw new NotImplementedException();
        }

        public Task<List<ListaAtivos>> ObterListaAtivos()
        {
            throw new NotImplementedException();
        }
    }
}

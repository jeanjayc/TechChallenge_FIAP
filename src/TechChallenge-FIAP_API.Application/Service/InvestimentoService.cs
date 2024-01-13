using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using RestSharp;
using TechChallenge_FIAP_API.Application.Interface;
using TechChallenge_FIAP_API.Domain.Entities;

namespace TechChallenge_FIAP_API.Application.Service
{
    public class InvestimentoService : IInvestimentoService
    {
        private readonly IConfiguration _configuration;

        public InvestimentoService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<DadosAtivo> ObterDadosAtivoPorNome(string nomeAtivo)
        {
            var url = _configuration.GetSection("url").Value;

            var client = new RestClient(url);

            var request = new RestRequest($"/{nomeAtivo}", Method.Get);

            var token = _configuration.GetSection("token").Value;

            request.AddParameter("Authorization", $"Bearer {token}", ParameterType.HttpHeader);

            var response = client.Execute<DadosAtivo>(request);

            return response.Data;

        }

        public async Task<ListaAtivos> ObterListaAtivos()
        {
            var url = _configuration.GetSection("url").Value;

            var client = new RestClient(url);

            var request = new RestRequest("/list", Method.Get);

            var token = _configuration.GetSection("token").Value;

            request.AddParameter("Authorization", $"Bearer {token}", ParameterType.HttpHeader);

            var response = client.Execute<ListaAtivos>(request);

            return response.Data;
        }
    }
}

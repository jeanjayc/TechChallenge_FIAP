using RestSharp;
using TechChallenge_FIAP_API.Domain.Entities;

namespace TechChallenge_FIAP_API.Application.Interface
{
    public interface IInvestimentoService
    {
        Task<RestResponse> ObterDadosAtivoPorNome(string nomeAtivo);
        Task<ListaAtivos> ObterListaAtivos();
    }
}

using TechChallenge_FIAP_API.Domain.Entities;

namespace TechChallenge_FIAP_API.Application.Interface
{
    public interface IInvestimentoService
    {
        Task<DadosAtivo> ObterDadosAtivo(string nomeAtivo);
        Task<List<ListaAtivos>> ObterListaAtivos();
    }
}

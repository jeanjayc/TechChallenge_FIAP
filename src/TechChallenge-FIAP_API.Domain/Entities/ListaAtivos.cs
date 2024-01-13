using TechChallenge_FIAP_API.Domain.Entities.ValueObjects;

namespace TechChallenge_FIAP_API.Domain.Entities
{
    public class ListaAtivos
    {
        public IndexAtivo[] indexes { get; set; }
        public Stock[] stocks { get; set; }
        public string[] availableSectors { get; set; }
        public string[] availableStockTypes { get; set; }
    }
}

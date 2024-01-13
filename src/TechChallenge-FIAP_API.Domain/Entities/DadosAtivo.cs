using TechChallenge_FIAP_API.Domain.Entities.ValueObjects;

namespace TechChallenge_FIAP_API.Domain.Entities
{
    public class DadosAtivo
    {
        public Result[] results { get; set; }
        public DateTime requestedAt { get; set; }
        public string took { get; set; }
    }
    
}

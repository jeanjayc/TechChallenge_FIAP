using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.Extensions.Configuration;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using System.Net;
using TechChallenge_FIAP_API.Application.Service;

public class InvestimentoServiceTest : IClassFixture<WebApplicationFactory<Program>>
{
    private readonly WebApplicationFactory<Program> _factory;
    private readonly IConfiguration _configuration;

    public InvestimentoServiceTest(WebApplicationFactory<Program> factory)
    {
        _factory = factory;
    }

    [Fact]
    public async Task ObterDadosAtivoPorNome_DeveRetornarStatusCodeOkENaoNulo()
    {
        // Arrange
        var service = new InvestimentoService();
        var nomeAtivo = "HGLG11";

        // Act
        var result = await service.ObterDadosAtivoPorNome(nomeAtivo);

        // Assert
        Assert.NotNull(result.Content);

        Assert.Equal(HttpStatusCode.OK, result.StatusCode);
    }
}

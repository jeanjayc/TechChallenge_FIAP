using Microsoft.Extensions.Configuration;
using Moq;
using RestSharp;
using System.Net;
using TechChallenge_FIAP_API.Application.Interface;
using Xunit;

namespace TechChallenge_FIAP_API.Tests.Application
{
    public class ApplicationTests
    {
        private readonly Mock<IInvestimentoService> _investimentoServiceMock;
        private readonly IConfiguration _configuration;

        public ApplicationTests(IConfiguration configuration)
        {
            _investimentoServiceMock = new Mock<IInvestimentoService>();
            _configuration = configuration;
        }

        [Fact]
        public async Task ObterAcaoPorNome_QuandoNomeValido_RetornaOk()
        {
            // Arrange
            var baseUrl = _configuration.GetSection("url").Value;
            var token = _configuration.GetSection("token").Value;

            var client = new RestClient(baseUrl);
            var request = new RestRequest(baseUrl, Method.Get);
            var restResponse = await client.ExecuteAsync(request);

            restResponse.StatusCode.Should().Be(HttpStatusCode.OK);

            //Act

            //Assert
        }

        //    [Fact]
        //    public async Task ObterAcaoPorNome_QuandoNomeInvalido_RetornaNotFound()
        //    {
        //        // Arrange
        //        var nome = "PETR4";
        //        Investimento investimento = null;

        //        _investimentoServiceMock.Setup(x => x.ObterDadosAtivoPorNome(nome)).ReturnsAsync(investimento);

        //        // Act
        //        var result = await _portalInvestimentosController.ObterAcaoPorNome(nome);

        //        // Assert
        //        Assert.IsType<NotFoundResult>(result);
        //    }

        //    [Fact]
        //    public async Task ObterListaAtivos_QuandoListaValida_RetornaOk()
        //    {
        //        // Arrange
        //        var investimentos = new List<Investimento>
        //        {
        //            new Investimento
        //            {
        //                Nome = "PETR4",
        //                Valor = 10.00M,
        //                Data = DateTime.Now
        //            },
        //            new Investimento
        //            {
        //                Nome = "VALE5",
        //                Valor = 20.00M,
        //                Data = DateTime.Now
        //            }
        //        };

        //        _investimentoServiceMock.Setup(x => x.ObterListaAtivos()).ReturnsAsync(investimentos);

        //        // Act
        //        var result = await _portalInvest
        //    }
        //}
    }
}

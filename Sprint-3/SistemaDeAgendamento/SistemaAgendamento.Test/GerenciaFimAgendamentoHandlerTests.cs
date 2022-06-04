using Moq;
using SistemaAgendamento.Core.Commands;
using SistemaAgendamento.Infrastructure;
using SistemaAgendamento.Services.Handlers;
using Xunit;

namespace SistemaAgendamento.Test
{
    public class GerenciaFimAgendamentoHandlerTests
    {
        Mock<GerenciaFimAgendamentoHandler> _handler;
        readonly Mock<IRepositorioAgendamento> _repositorio;

        public GerenciaFimAgendamentoHandlerTests()
        {
            _repositorio = new Mock<IRepositorioAgendamento>();
        }

        [Fact]
        public void VerifyMethodCall()
        {
            //Arrange
            _handler = new Mock<GerenciaFimAgendamentoHandler>(_repositorio.Object);
            var gerenciaFimAgendamento = new GerenciaFimAgendamento();

            //act
            _handler.Object.Execute(gerenciaFimAgendamento);

            //assert
            _repositorio.Verify(x => x.AtualizarAgendamentos(), Times.Once());
        }
    }
}
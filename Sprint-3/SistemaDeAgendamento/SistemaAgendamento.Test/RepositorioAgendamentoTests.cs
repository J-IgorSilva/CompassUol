using System;
using Microsoft.EntityFrameworkCore;
using Moq;
using Newtonsoft.Json;
using SistemaAgendamento.Core.Models;
using SistemaAgendamento.Infrastructure;
using Xunit;

namespace SistemaAgendamento.Test
{
    public class RepositorioAgendamentoTest
    {
        readonly Mock<IRepositorioAgendamento> _repositorio;
        readonly RepositorioAgendamento _repositorioInMemory;

        public RepositorioAgendamentoTest()
        {
            _repositorio = new Mock<IRepositorioAgendamento>();

            var dbOptions = new DbContextOptionsBuilder<Infrastructure.DbContext>()
                            .UseInMemoryDatabase(databaseName: "ToDoDb")
                            .Options;

            var context = new Infrastructure.DbContext(dbOptions);

            _repositorioInMemory = new RepositorioAgendamento(context);
        }

        [Fact]
        public void IncluirAgendamentoInMemoryTest()
        {
            //Arrange
            var sala = new Sala(1, "Sala 1");
            var agendamento = new AgendamentoModel(1, "Agendamento de teste", sala, DateTime.Now.AddHours(-1), DateTime.Now, StatusAgendamento.Criada);

            //Act
            _repositorioInMemory.IncluirAgendamento(agendamento);
            var novoAgendamento = _repositorioInMemory.ObtemAgendamentoPorId(1);

            //Assert
            var agendamentoJson = JsonConvert.SerializeObject(agendamento);
            var novoAgendamentoJson = JsonConvert.SerializeObject(novoAgendamento);
            Assert.Equal(agendamentoJson, novoAgendamentoJson);
        }

        [Fact]
        public void IncluirAgendamentoExceptionTest()
        {
            //Arrange
            _repositorio.Setup(x => x.IncluirAgendamento(It.IsAny<AgendamentoModel>())).Throws(new System.ArgumentException("Teste de erro"));
            var sala = new Sala(1, "Sala 1");
            var agendamento = new AgendamentoModel(1, "Agendamento de teste", sala, DateTime.Now.AddHours(-1), DateTime.Now, StatusAgendamento.Criada);

            //Act
            Action act = () => _repositorio.Object.IncluirAgendamento(agendamento);

            //Assert
            var exception = Assert.Throws<ArgumentException>(act);
            Assert.Equal("Teste de erro", exception.Message);
        }
    }
}
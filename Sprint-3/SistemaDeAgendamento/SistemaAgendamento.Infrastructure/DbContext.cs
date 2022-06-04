using SistemaAgendamento.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace SistemaAgendamento.Infrastructure
{
    public class DbContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public DbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<AgendamentoModel> Agendamento { get; set; }
        public DbSet<Sala> Sala { get; set; }
    }
}

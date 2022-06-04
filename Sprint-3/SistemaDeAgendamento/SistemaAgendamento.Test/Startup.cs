
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SistemaAgendamento.Infrastructure;

namespace SistemaAgendamento.Test
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<IRepositorioAgendamento, RepositorioAgendamento>();
            services.AddDbContext<Infrastructure.DbContext>(opt => opt.UseSqlServer("Server = (localdb)\\mssqllocaldb; Database = DbTarefas; Trusted_Connection = true"));
        }
    }
}

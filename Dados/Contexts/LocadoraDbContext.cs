using Dados.Models;
using Microsoft.EntityFrameworkCore;

namespace Dados.Contexts
{
    public class LocadoraDbContext : DbContext
    {
        public LocadoraDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<ClienteDataModel> Cliente { get; set; }
        public DbSet<AluguelDataModel> Aluguel { get; set; }
        public DbSet<CarroDataModel> Carro { get; set; }
        public DbSet<CarroCategoriaDataModel> CarroCategoria { get; set; }
        public DbSet<ReservaDataModel> Reserva { get; set; }

    }
}

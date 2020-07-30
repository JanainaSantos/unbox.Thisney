using Microsoft.EntityFrameworkCore;
using Unbox.Thisney.API.Model;

namespace Unbox.Thisney.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Estoque> Estoque { get; set; }
        public DbSet<Evento> Evento { get; set; }
        public DbSet<Ingresso> Ingresso { get; set; }
        public DbSet<Venda> Venda { get; set; }

    }
}
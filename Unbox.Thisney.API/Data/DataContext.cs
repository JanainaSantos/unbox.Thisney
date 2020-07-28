using Microsoft.EntityFrameworkCore;
using Unbox.Thisney.API.Model;

namespace Unbox.Thisney.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<Venda> Vendas { get; set; }

    }
}
using Microsoft.EntityFrameworkCore;
using MvcAulaDesktop.Models;
namespace MvcAulaDesktop.Data
{
    public class DataContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=JUN0635432W10-1\\BDSENAC;Initial Catalog=BancoTeste;User Id=senaclivre;Password='senaclivre'");
        }
        public DbSet<ClienteModel> Clientes { get; set; }
    }
}

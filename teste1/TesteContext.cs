using Microsoft.EntityFrameworkCore;

namespace teste
{
    public class TesteContext : DbContext {
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<ClientePessoaFisica> ClientesPF { get; set; }
        public DbSet<ClientePessoaJuridica> ClientesPJ { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.;Database=Softwear;Trusted_Connection=True;MultipleActiveResultSets=true");
        }
    }
}
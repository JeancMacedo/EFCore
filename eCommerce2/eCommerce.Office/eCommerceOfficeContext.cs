using eCommerce.Office.Models;
using Microsoft.EntityFrameworkCore;

namespace eCommerce.Office
{
    public class eCommerceOfficeContext : DbContext
    {
        public DbSet<Colaborador>? Colaboradores { get; set; }
        public DbSet<Setor>? Setores { get; set; }
        public DbSet<Turma>? Turmas { get; set; }
        public DbSet<Veiculo>? Veiculos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=eCommerceOffice;Integrated Security=True;");
        }
    }
}

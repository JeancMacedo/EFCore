using eCommerce2.Models;
using eCommerce2.Models.FluentAPI;
using Microsoft.EntityFrameworkCore;


namespace eCommerce.Models.FluentAPI
{
    internal class eCommerceFluentContext : DbContext
    {
        public eCommerceFluentContext(DbContextOptions<eCommerceFluentContext> options) : base(options)
        {

        }
        public DbSet<Usuario>? Usuarios { get; set; }
        public DbSet<Contato>? Contatos { get; set; }
        public DbSet<EnderecoEntrega>? EnderecosEntrega { get; set; }
        public DbSet<Departamento>? Departamentos { get; set; }

    }
}

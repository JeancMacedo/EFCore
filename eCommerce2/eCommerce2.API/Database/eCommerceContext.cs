using Microsoft.EntityFrameworkCore;

namespace eCommerce2.API.Database
{
    public class eCommerceContext : DbContext
    {
        public eCommerceContext(DbContextOptions<eCommerceContext> options) : base(options)
        {

        }

        #region Conexão sem distinção de ambientes de execução
        /*protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=eCommerce;Integrated Security=True;");
        }
        */
        #endregion
    }
}

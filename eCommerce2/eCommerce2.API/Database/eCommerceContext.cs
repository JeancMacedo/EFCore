using Microsoft.EntityFrameworkCore;

namespace eCommerce2.API.Database
{
    public class eCommerceContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=eCommerce;Integrated Security=True;");
        }
    }
}

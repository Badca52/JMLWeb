using JMLWeb.Business.Product;
using System.Data.Entity;

namespace JMLWeb.DataAccess
{
    public partial class DataContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
    }
}

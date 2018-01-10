using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 自定义Code_First约定的方式A
{
    public class ProductContext : DbContext
    {
        static ProductContext()
        {
            Database.SetInitializer(
                new DropCreateDatabaseIfModelChanges<ProductContext>());
        }

        public DbSet<Product> Products { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 自定义Code_First约定的方式B
{
    public class ProductContext : DbContext
    {
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Types().Configure(entity => entity.ToTable("Shop_" + entity.ClrType.Name));
        }

        public DbSet<Product> Products { get; set; }
    }
}

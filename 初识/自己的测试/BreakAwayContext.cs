using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Common;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 自己的测试
{
    public class BreakAwayContext : DbContext
    {
        public BreakAwayContext(DbConnection connection) :
            base(connection, contextOwnsConnection: false)
        {
        }

        public DbSet<User> UserInfo { get; set; }

        /// <summary>
        /// Fluent API
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //Fluent API
            // modelBuilder.Entity<User>().Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            base.OnModelCreating(modelBuilder);
        }
    }
}

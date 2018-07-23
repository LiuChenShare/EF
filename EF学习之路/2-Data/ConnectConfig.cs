using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Data
{
    public partial class ConnectConfig : DbContext
    {
        public ConnectConfig()
            : base("data source=.;initial catalog=test1;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework")
                //data source=DESKTOP-D51E9P0;initial catalog=Chenyuan-Base;persist security info=True;user id=sa;password=l88888888;
        {
        }

        public virtual DbSet<Address> Address { get; set; }
        public virtual DbSet<Article> Article { get; set; }
        public virtual DbSet<User> User { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}

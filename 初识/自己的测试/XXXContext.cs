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
    public class XXXContext : DbContext
    {
        public XXXContext() : base("DefaultConnection") { }

        public DbSet<User> UserInfo { get; set; }

    }
}

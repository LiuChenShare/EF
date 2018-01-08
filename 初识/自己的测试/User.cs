using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 自己的测试
{
    public class User
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        //modelBuilder.Entity<Person>().Property(p => p.SocialId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

        public string Name { get; set; }

        public string Department { get; set; }
    }
}

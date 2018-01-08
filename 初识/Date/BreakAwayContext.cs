using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Common;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Date
{
    public class BreakAwayContext : DbContext
    {
        public BreakAwayContext(DbConnection connection) :
            base(connection, contextOwnsConnection: false)
        {
        }

        public DbSet<Destination> Destinations { get; set; }
        public DbSet<Lodging> Lodgings { get; set; }

        /// <summary>
        /// Fluent API
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //Fluent API
            //设置主键
            modelBuilder.Entity<Destination>().HasKey(d => d.DestinationId);
            //设置外键
            modelBuilder.Entity<Lodging>().HasRequired(p => p.Destination).WithMany(p => p.Lodgings).HasForeignKey(p => p.DestinationId);
            //设置长度
            modelBuilder.Entity<Destination>().Property(p => p.Name).HasMaxLength(30);
            modelBuilder.Entity<Destination>().Property(p => p.Country).HasMaxLength(30);
            //设置非空
            modelBuilder.Entity<Destination>().Property(p => p.Country).IsRequired();
            //设置数据类型
            modelBuilder.Entity<Lodging>().Property(p => p.Owner).HasColumnType("ntext");
            //设置表名
            modelBuilder.Entity<Lodging>().ToTable("MyLodging");
            //设置列名
            modelBuilder.Entity<Lodging>().Property(p => p.Name).HasColumnName("MyName");
            //设置自增长
            modelBuilder.Entity<Person>().Property(p => p.SocialId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            //忽略列映射
            modelBuilder.Entity<Person>().Ignore(p => p.Name);
            //忽略表映射
            modelBuilder.Ignore<Person>();
            //时间戳
            modelBuilder.Entity<Lodging>().Property(p => p.TimeStamp).IsRowVersion();
            //复杂类型
            modelBuilder.ComplexType<Address>();
            base.OnModelCreating(modelBuilder);
        }
    }
}

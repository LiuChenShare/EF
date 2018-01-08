using Date;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 初识
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var destination = new Destination
                {
                    Country = "Indonesia",
                    Description = "EcoTourism at its best in exquisite Bali",
                    Name = "Bali"
                };

                var lodging = new Lodging
                {
                    Name = "Rainy Day Motel",
                };

                var cstr = @"Server=DESKTOP-D51E9P0; Database=BreakAway;User ID=sa;Password=l88888888";
                //Data Source=DESKTOP-D51E9P0;Persist Security Info=True;User ID=sa;Password=***********
                //Data Source=DESKTOP-D51E9P0;Initial Catalog=master;Persist Security Info=True;User ID=sa;Password=***********
                using (var connection = new SqlConnection(cstr))
                {
                    using (var context = new BreakAwayContext(connection))
                    {
                        context.Lodgings.Add(lodging);
                        context.SaveChanges();
                    }
                }
            }
            catch (System.Data.Entity.Validation.DbEntityValidationException ex)
            {
                Console.WriteLine(" 保存失败! 错误信息：" + ex.Message);
            }
            Console.WriteLine("OK");
            Console.Read();
        }
    }
}

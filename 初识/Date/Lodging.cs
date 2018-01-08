using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Date
{
    [Table("MyLodging")]
    public class Lodging
    {
        public int LodgingId { get; set; }

        [Column("MyName")]
        public string Name { get; set; }

        //将string映射成ntext，默认为nvarchar(max)
        [Column(TypeName = "ntext")]
        public string Owner { get; set; }

        public bool IsResort { get; set; }

        public int DestinationId { get; set; }

        [ForeignKey("DestinationId")]
        public Destination Destination { get; set; }

        [Timestamp]
        public Byte[] TimeStamp { get; set; }
    }
}

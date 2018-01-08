using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Date
{
    public class Destination
    {
        [Key]
        public int DestinationId { get; set; }

        [MinLength(10), MaxLength(30)]
        public string Name { get; set; }

        [StringLength(30)]
        [Required]
        public string Country { get; set; }

        [Required(ErrorMessage = "请输入描述")]
        public string Description { get; set; }

        public byte[] Photo { get; set; }

        public List<Lodging> Lodgings { get; set; }
    }
}

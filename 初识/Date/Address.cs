using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Date
{
    [ComplexType]
    public class Address
    {
        public string Country { get; set; }
        public string City { get; set; }
    }
}

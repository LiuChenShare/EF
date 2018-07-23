using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Data
{
    /// <summary>
    /// 地址信息
    /// （这是个复杂类型）
    /// </summary>
    [ComplexType]
    public class Address
    {
        /// <summary>
        /// 街道
        /// </summary>
        public string Street { get; set; }

        /// <summary>
        /// 地区唯一标示
        /// </summary>
        public string Marking { get; set; }
    }
}

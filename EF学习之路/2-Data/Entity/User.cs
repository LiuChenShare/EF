using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Data
{
    /// <summary>
    /// 用户表
    /// </summary>
    public class User
    {
        /// <summary>
        /// 用户id
        /// </summary>
        [Key]
        public int UserId { get; set; }

        /// <summary>
        /// 用户名称
        /// </summary>
        [Required]
        [StringLength(10)]
        public string UserName { get; set; }

        /// <summary>
        /// 地址信息
        /// </summary>
        [Required]
        public Address Address { get; set; }


        /// <summary>
        /// 作者信息
        /// </summary>
        public virtual List<Article> Articles { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Data
{
    /// <summary>
    /// 文章信息
    /// </summary>
    public class Article
    {
        /// <summary>
        /// 文章id
        /// </summary>
        [Key]
        public Guid ArticleId { get; set; }

        /// <summary>
        /// 作者id
        /// </summary>
        public int UserId { get; set; }

        /// <summary>
        /// 标题
        /// </summary>
        public string Title { get; set; }



        /// <summary>
        /// 作者信息
        /// </summary>
        public virtual User User { get; set; }                  //virtual属性是延迟加载的意思
    }
}

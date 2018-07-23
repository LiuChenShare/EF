namespace _1_Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Article")]
    public partial class Article
    {
        public Guid Id { get; set; }

        [Required]
        [StringLength(10)]
        public string Title { get; set; }

        public int UserId { get; set; }

        public virtual User User { get; set; }
    }
}

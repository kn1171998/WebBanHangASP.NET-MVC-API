﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebModel.Abstract;

namespace WebModel.Models
{
    [Table("PostCategories")]
    public class PostCategory : Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }

        [Required]
        [MaxLength(250)]
        public string Name { set; get; }

        [Required]
        [MaxLength(250)]
        public string Alias { set; get; }

        [MaxLength(500)]
        public string Description { set; get; }

        public int ParentID { set; get; }
        public int DisplayOrder { set; get; }

        [MaxLength(500)]
        public string Image { set; get; }

        public bool HomeFlag { set; get; }
        public virtual IEnumerable<PostCategory> PostCategories { set; get; }
    }
}
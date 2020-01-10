using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebModel.Abstract;

namespace WebModel.Models
{
    [Table("Posts")]
    public class Post : Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }

        [MaxLength(250)]
        [Required]
        public string Name { set; get; }

        [MaxLength(250)]
        [Required]
        public string Alias { set; get; }

        public int? CaterogyID { set; get; }
        [ForeignKey("PostCategory")]
        public virtual PostCategory PostCategory { set; get; }

        [MaxLength(500)]
        public string Image { set; get; }

        [MaxLength(500)]
        public string Description { set; get; }

        public string Content { set; get; }
        public bool? HomeFlag { set; get; }
        public bool? HotFlag { set; get; }
        public int? ViewCount { set; get; }
        public virtual IEnumerable<PostTag> PostTags { set; get; }
    }
}
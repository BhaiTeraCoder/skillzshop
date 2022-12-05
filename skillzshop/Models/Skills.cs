using skillzshop.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace skillzshop.Models
{
    public class Skills
    {
        [Key]
        public int SkillId { get; set; }
        public string? Name { get; set; }

        //[DataType(DataType.Date)]
        //public DateTime ReleaseDate { get; set; }
        public string? Description { get; set; }
        public double? Price { get; set; }

        public string? SellerName { get; set; }
        public double? Rating { get; set; }

        //Relationships Category
        public int CategoryId  { get; set; }
        [ForeignKey("CategoryId")]
        public virtual Category? Category { get; set; }

    }
}

using System.ComponentModel.DataAnnotations;

namespace skillzshop.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }

        //Relationships
        public List<Skills> Skills { get; set; }
    }
}

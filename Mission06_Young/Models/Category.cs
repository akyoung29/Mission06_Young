using System.ComponentModel.DataAnnotations;

namespace Mission06_Young.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        public required string CategoryName {  get; set; }
    }
}

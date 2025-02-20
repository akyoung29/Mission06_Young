using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mission06_Young.Models
{
    public class Form
    {
        [Key]
        public int? MovieId { get; set; }
        
        [ForeignKey ("CategoryId")]
        public int? CategoryID { get; set; }
        public Category Category { get; set; }
        
        public string? Title { get; set; }
        
        public string? Year { get; set; }
       
        public string? Director { get; set; }
        
        public string? Rating { get; set; }
        public bool? Edited { get; set; }
        public string? LentTo { get; set; }
        public bool? CopiedToPlex { get; set; }
        public string? Notes { get; set; }

    }
}

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mission06_Young.Models
{
    public class Form
    {
        // Features from data, with title, year, edited, and copied to plex required

        //Movie Id
        [Key]
        public int MovieId { get; set; }
        
        // Category Id (that links to Categories table)
        [ForeignKey ("CategoryId")]
        public int CategoryId { get; set; }
        public Category? Category { get; set; }

        //Title
        [Required]
        public string Title { get; set; }

        //Year (not less than 1888)
        [Required]
        [Range(1888, int.MaxValue, ErrorMessage = "Year must be 1888 or later.")]
        public int Year { get; set; } = 0;
       
        //Director
        public string? Director { get; set; }
        
        //Rating
        public string? Rating { get; set; }

        //Edited
        [Required]
        public bool Edited { get; set; }

        //Lent To
        public string? LentTo { get; set; }

        // Copied To Plex
        [Required]
        public bool CopiedToPlex { get; set; }

        // Notes
        public string? Notes { get; set; }

    }
}

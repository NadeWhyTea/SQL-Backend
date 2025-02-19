using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SQL_Backend.Models
{
    public class Students
    {
        [Key]
        [Column("StudentId")]
        public int StudentId { get; set; }

        [Column("Name")]
        public string? Name { get; set; }

        [Column("Year")]
        public string? Year { get; set; }

    }
}

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SQL_Backend.Models
{
    public class Teachers
    {
        [Key]
        [Column("TeacherId")]
        public int TeacherId { get; set; }

        [Column("Name")]
        public string? Name { get; set; }

        [Column("Experience")]
        public int Experience { get; set; }
    }
}

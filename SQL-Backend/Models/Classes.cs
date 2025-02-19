using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;


namespace SQL_Backend.Models
{
    [Table("classes")]
    public partial class Classes
    {
        [Key]
        [Column("ClassId")]
        public int ClassId { get; set; }

        [Column("Name")]
        public string? Name { get; set; }

        [Column("Grade")]
        public int Grade { get; set; }

        [Column("TotalStudents")]
        public int TotalStudents { get; set; }

        [ForeignKey("Teachers")]
        [Column("TeacherId")]
        public int TeacherId { get; set; }
        public Teachers? Teachers { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;

namespace TiimeTableGenerator.Models
{
    public class Subject
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
    }

}


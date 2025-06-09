using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Test2.Models;

[Table("Race")]
public class Race
{
    [Key]
    public int RaceId { get; set; }
    
    [MaxLength(50)]
    [Required]
    public required string Name { get; set; }
    
    [MaxLength(100)]
    [Required]
    public required string Location { get; set; }
    
    [Required]
    public DateTime Date { get; set; }
}
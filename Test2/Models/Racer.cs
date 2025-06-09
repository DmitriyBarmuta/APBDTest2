using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Test2.Models;

[Table("Racer")]
public class Racer
{
    [Key]
    public int RacerId { get; set; }
    
    [MaxLength(50)]
    [Required]
    public required string FirstName { get; set; }
    
    [MaxLength(100)]
    [Required]
    public required string LastName { get; set; }

    public List<RaceParticipation> RaceParticipations { get; set; } = [];
}
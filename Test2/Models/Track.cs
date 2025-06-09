using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Test2.Models;

[Table("Track")]
public class Track
{
    [Key]
    public int TrackId { get; set; }
    
    [MaxLength(100)]
    [Required]
    public required string Name { get; set; }
    
    [Precision(5, 2)]
    [Required]
    public decimal LengthInKm { get; set; }
}
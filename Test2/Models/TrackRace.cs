using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Test2.Models;

[Table("Track_Race")]
public class TrackRace
{
    [Key]
    public int TrackRaceId { get; set; }
    
    [Required]
    public int TrackId { get; set; }
    
    [Required]
    public int RaceId { get; set; }
    
    [Required]
    public int Laps { get; set; }
    
    public int BestTimeInSeconds { get; set; }

    [ForeignKey(nameof(TrackId))]
    public Track Track { get; set; } = null!;

    [ForeignKey(nameof(RaceId))]
    public Race Race { get; set; } = null!;
    
    public List<RaceParticipation> Participations { get; set; } = [];
}
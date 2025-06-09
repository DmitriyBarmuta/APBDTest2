using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Test2.Models;

[Table("Race_Participation")]
public class RaceParticipation
{
    [Required]
    public int TrackRaceId { get; set; }
    
    [Required]
    public int RacerId { get; set; }
    
    [Required]
    public int FinishTimeInSeconds { get; set; }
    
    [Required]
    public int Position { get; set; }

    [ForeignKey(nameof(TrackRaceId))] 
    public TrackRace TrackRace { get; set; } = null!;
    
    [ForeignKey(nameof(RacerId))]
    public virtual Racer Racer { get; set; } = null!;
}
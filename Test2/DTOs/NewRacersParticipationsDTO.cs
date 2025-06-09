namespace Test2.DTOs;

public class NewRacersParticipationsDTO
{
    public required string RaceName { get; set; }
    public required string TrackName { get; set; }
    public List<NewParticipationDTO> Participations { get; set; } = [];
}
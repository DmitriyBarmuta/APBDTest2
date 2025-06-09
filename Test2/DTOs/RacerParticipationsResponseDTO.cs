namespace Test2.DTOs;

public class RacerParticipationsResponseDTO
{
    public int RacerId { get; set; }
    public required string FirstName { get; set; }
    public required string LastName { get; set; }
    public List<RacerSingleParticipationResponseDTO> Participations { get; set; } = [];
}
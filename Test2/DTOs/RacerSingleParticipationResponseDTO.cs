namespace Test2.DTOs;

public class RacerSingleParticipationResponseDTO
{
    public ResponseRaceDTO Race { get; set; }
    public ResponseTrackDTO Track { get; set; }
    public int Laps { get; set; }
    public int FinishTimeInSeconds { get; set; }
    public int Position { get; set; }
}
using Test2.Models;

namespace Test2.Repositories;

public interface ITrackRacesRepository
{
    Task<TrackRace?> GetByTrackAndRaceNamesAsync(int raceId, int trackId, CancellationToken cancellationToken);
    Task SaveDataAsync(CancellationToken cancellationToken);
    Task AddParticipationAsync(RaceParticipation newParticipation, CancellationToken cancellationToken);
    Task<RaceParticipation?> GetParticipationAsync(int trackRaceId, int racerId, CancellationToken cancellationToken);
}
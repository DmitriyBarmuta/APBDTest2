using Test2.Models;

namespace Test2.Repositories;

public interface ITrackRacesRepository
{
    Task<TrackRace?> GetByTrackAndRaceNamesAsync(int raceId, int trackId, CancellationToken cancellationToken);
    Task SaveDataAsync(CancellationToken cancellationToken);
}
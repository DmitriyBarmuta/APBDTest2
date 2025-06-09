using Test2.DTOs;

namespace Test2.Services;

public interface ITrackRacesService
{
    Task AddNewRacersParticipations(NewRacersParticipationsDTO dto, CancellationToken cancellationToken);
}
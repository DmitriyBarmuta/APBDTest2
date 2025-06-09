using Test2.DTOs;
using Test2.Repositories;

namespace Test2.Services;

public class TrackRacesService : ITrackRacesService
{
    private readonly ITrackRacesRepository _trackRacesRepository;

    public TrackRacesService(ITrackRacesRepository trackRacesRepository)
    {
        _trackRacesRepository = trackRacesRepository;
    }

    public Task AddNewRacersParticipations(NewRacersParticipationsDTO dto, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
using Test2.DTOs;
using Test2.Repositories;

namespace Test2.Services;

public class TrackRacesService : ITrackRacesService
{
    private readonly ITrackRacesRepository _trackRacesRepository;
    private readonly TracksRepository _tracksRepository;
    private readonly IRacesRepository _racesRepository;

    public TrackRacesService(ITrackRacesRepository trackRacesRepository, 
        TracksRepository tracksRepository, IRacesRepository racesRepository)
    {
        _trackRacesRepository = trackRacesRepository;
        _tracksRepository = tracksRepository;
        _racesRepository = racesRepository;
    }

    public Task AddNewRacersParticipations(NewRacersParticipationsDTO dto, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
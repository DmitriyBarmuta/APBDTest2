using Test2.DTOs;
using Test2.Exceptions;
using Test2.Models;
using Test2.Repositories;

namespace Test2.Services;

public class TrackRacesService : ITrackRacesService
{
    private readonly ITrackRacesRepository _trackRacesRepository;
    private readonly ITracksRepository _tracksRepository;
    private readonly IRacesRepository _racesRepository;

    public TrackRacesService(ITrackRacesRepository trackRacesRepository, 
        ITracksRepository tracksRepository, IRacesRepository racesRepository)
    {
        _trackRacesRepository = trackRacesRepository;
        _tracksRepository = tracksRepository;
        _racesRepository = racesRepository;
    }

    public async Task AddNewRacersParticipations(NewRacersParticipationsDTO dto, CancellationToken cancellationToken)
    {
        var race = await _racesRepository.GetByNameAsync(dto.RaceName, cancellationToken);
        if (race == null)
            throw new NoSuchRaceException($"There's no race with name '{dto.RaceName}'.");

        var track = await _tracksRepository.GetByNameAsync(dto.TrackName, cancellationToken);
        if (track == null)
            throw new NoSuchTrackException($"There's no track with name '{dto.TrackName}'.");
        
        var trackRace = await _trackRacesRepository.GetByTrackAndRaceNamesAsync(race.RaceId, track.TrackId, cancellationToken);
        if (trackRace == null)
            throw new NoSuchTrackException($"There was no track race between '{race.Name}' and '{track.Name}'.");
        
        foreach (var participation in dto.Participations)
        {
            var existingParticipation = trackRace.Participations.FirstOrDefault(p => p.RacerId == participation.RacerId);
            if (existingParticipation == null)
            {
                trackRace.Participations.Add(new RaceParticipation
                {
                    TrackRaceId = trackRace.TrackRaceId,
                    RacerId = participation.RacerId,
                    FinishTimeInSeconds = participation.FinishTimeInSeconds,
                    Position = participation.Position
                });
            }
            else
            {
                if (existingParticipation.FinishTimeInSeconds <= participation.FinishTimeInSeconds) continue;
                existingParticipation.FinishTimeInSeconds = participation.FinishTimeInSeconds;
                existingParticipation.Position = participation.Position;
            }

            if (trackRace.BestTimeInSeconds > participation.FinishTimeInSeconds)
            {
                trackRace.BestTimeInSeconds = participation.FinishTimeInSeconds;
            }
        }

        await _trackRacesRepository.SaveDataAsync(cancellationToken);
    }
}
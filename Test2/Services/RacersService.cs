using Test2.DTOs;
using Test2.Exceptions;
using Test2.Repositories;

namespace Test2.Services;

public class RacersService : IRacersService
{
    private readonly IRacersRepository _racersRepository;

    public RacersService(IRacersRepository racersRepository)
    {
        _racersRepository = racersRepository;
    }

    public async Task<RacerParticipationsResponseDTO> GetAllParticipationsById(int racerId,
        CancellationToken cancellationToken)
    {
        var racerInfo = await _racersRepository.GetById(racerId, cancellationToken);
        if (racerInfo == null)
            throw new NoSuchRacerException($"There's no racer with id '{racerId}'.");

        return new RacerParticipationsResponseDTO
        {
            RacerId = racerInfo.RacerId,
            FirstName = racerInfo.FirstName,
            LastName = racerInfo.LastName,
            Participations = racerInfo.RaceParticipations.Select(
                rp => new RacerSingleParticipationResponseDTO
                {
                    Race = new ResponseRaceDTO
                    {
                        Name = rp.TrackRace.Race.Name,
                        Location = rp.TrackRace.Race.Location,
                        Date = rp.TrackRace.Race.Date,
                    },
                    Track = new ResponseTrackDTO
                    {
                        Name = rp.TrackRace.Track.Name,
                        LengthInKm = rp.TrackRace.Track.LengthInKm
                    },
                    Laps = rp.TrackRace.Laps,
                    FinishTimeInSeconds = rp.FinishTimeInSeconds,
                    Position = rp.Position
                }
            ).ToList()
        };
    }
}
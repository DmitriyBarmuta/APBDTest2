using Microsoft.EntityFrameworkCore;
using Test2.Data;
using Test2.Models;

namespace Test2.Repositories;

public class TrackRacesRepository : ITrackRacesRepository
{
    private readonly DatabaseContext _context;

    public TrackRacesRepository(DatabaseContext context)
    {
        _context = context;
    }

    public async Task<TrackRace?> GetByTrackAndRaceNamesAsync(int raceId, int trackId, CancellationToken cancellationToken)
    {
        return await _context.TrackRaces.FirstOrDefaultAsync(tr => tr.RaceId == raceId && tr.TrackId == trackId, cancellationToken);
    }

    public async Task SaveDataAsync(CancellationToken cancellationToken)
    {
        await _context.SaveChangesAsync(cancellationToken);
    }

    public async Task AddParticipationAsync(RaceParticipation newParticipation, CancellationToken cancellationToken)
    {
        await _context.RaceParticipations.AddAsync(newParticipation, cancellationToken);
    }

    public async Task<RaceParticipation?> GetParticipationAsync(int trackRaceId, int racerId, CancellationToken cancellationToken)
    {
        return await _context.RaceParticipations
            .FirstOrDefaultAsync(rp => rp.TrackRaceId == trackRaceId && rp.RacerId == racerId, cancellationToken);
    }
}
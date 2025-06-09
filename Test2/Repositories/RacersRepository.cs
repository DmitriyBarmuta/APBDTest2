using Microsoft.EntityFrameworkCore;
using Test2.Data;
using Test2.Models;

namespace Test2.Repositories;

public class RacersRepository : IRacersRepository
{
    private readonly DatabaseContext _context;

    public RacersRepository(DatabaseContext context)
    {
        _context = context;
    }

    public async Task<Racer?> GetById(int racerId, CancellationToken cancellationToken)
    {
        return await _context.Racers
            .Where(r => r.RacerId == racerId)
            .Include(r => r.RaceParticipations)
                .ThenInclude(rp => rp.TrackRace)
                    .ThenInclude(rp => rp.Race)
            .Include(r => r.RaceParticipations)
                .ThenInclude(rp => rp.TrackRace)
                    .ThenInclude(rp => rp.Track)
            .FirstOrDefaultAsync(cancellationToken);
    }
}
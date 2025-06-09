using Microsoft.EntityFrameworkCore;
using Test2.Data;
using Test2.Models;

namespace Test2.Repositories;

public class TracksRepository : ITracksRepository
{
    private readonly DatabaseContext _context;

    public TracksRepository(DatabaseContext context)
    {
        _context = context;
    }

    public async Task<Track?> GetByNameAsync(string trackName, CancellationToken cancellationToken)
    {
        return await _context.Tracks.FirstOrDefaultAsync(t => t.Name == trackName, cancellationToken);
    }
}
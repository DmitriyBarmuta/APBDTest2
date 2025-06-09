using Microsoft.EntityFrameworkCore;
using Test2.Data;
using Test2.Models;

namespace Test2.Repositories;

public class RacesRepository : IRacesRepository
{
    private readonly DatabaseContext _context;

    public RacesRepository(DatabaseContext context)
    {
        _context = context;
    }

    public async Task<Race?> GetByNameAsync(string raceName, CancellationToken cancellationToken)
    {
        return await _context.Races.FirstOrDefaultAsync(r => r.Name == raceName, cancellationToken);
    }
}
using Test2.Data;

namespace Test2.Repositories;

public class RacesRepository : IRacesRepository
{
    private readonly DatabaseContext _context;

    public RacesRepository(DatabaseContext context)
    {
        _context = context;
    }
}
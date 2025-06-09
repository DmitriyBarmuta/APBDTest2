using Test2.Data;

namespace Test2.Repositories;

public class TracksRepository : ITracksRepository
{
    private readonly DatabaseContext _context;

    public TracksRepository(DatabaseContext context)
    {
        _context = context;
    }
}
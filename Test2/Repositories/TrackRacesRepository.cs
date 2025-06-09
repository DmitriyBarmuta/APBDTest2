using Test2.Data;

namespace Test2.Repositories;

public class TrackRacesRepository : ITrackRacesRepository
{
    private readonly DatabaseContext _context;

    public TrackRacesRepository(DatabaseContext context)
    {
        _context = context;
    }
}
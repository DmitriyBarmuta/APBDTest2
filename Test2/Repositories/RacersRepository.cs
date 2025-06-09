using Test2.Data;

namespace Test2.Repositories;

public class RacersRepository
{
    private readonly DatabaseContext _context;

    public RacersRepository(DatabaseContext context)
    {
        _context = context;
    }
}
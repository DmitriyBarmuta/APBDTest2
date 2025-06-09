using Test2.Models;

namespace Test2.Repositories;

public interface IRacesRepository
{
    Task<Race?> GetByNameAsync(string raceName, CancellationToken cancellationToken);
}
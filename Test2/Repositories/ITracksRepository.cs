using Test2.Models;

namespace Test2.Repositories;

public interface ITracksRepository
{
    Task<Track?> GetByNameAsync(string trackName, CancellationToken cancellationToken);
}
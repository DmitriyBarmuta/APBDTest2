using Test2.Models;

namespace Test2.Repositories;

public interface IRacersRepository
{
    Task<Racer?> GetById(int racerId, CancellationToken cancellationToken);
}
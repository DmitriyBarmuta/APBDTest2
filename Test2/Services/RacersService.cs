using Test2.DTOs;
using Test2.Repositories;

namespace Test2.Services;

public class RacersService : IRacersService
{
    private readonly IRacersRepository _racersRepository;

    public RacersService(IRacersRepository racersRepository)
    {
        _racersRepository = racersRepository;
    }

    public Task<RacerParticipationsResponseDTO> GetAllParticipationsById(int racerId, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
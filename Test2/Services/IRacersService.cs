using Test2.DTOs;

namespace Test2.Services;

public interface IRacersService
{
    Task<RacerParticipationsResponseDTO> GetAllParticipationsById(int racerId, CancellationToken cancellationToken);
}
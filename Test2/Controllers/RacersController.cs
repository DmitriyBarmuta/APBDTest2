using Microsoft.AspNetCore.Mvc;
using Test2.Exceptions;
using Test2.Services;

namespace Test2.Controllers;

[ApiController]
[Route("api/[controller]")]
public class RacersController : ControllerBase
{
    private readonly IRacersService _racersService;

    public RacersController(IRacersService racersService)
    {
        _racersService = racersService;
    }

    [HttpGet("{racerId:int}/participations")]
    public async Task<IActionResult> GetAllRacerParticipationsById(int racerId, CancellationToken cancellationToken = default)
    {
        try
        {
            var result = await _racersService.GetAllParticipationsById(racerId, cancellationToken);
            return Ok(result);
        }
        catch (NoSuchRacerException ex)
        {
            return NotFound(new { message = ex.Message });
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { error = "Internal Server Error.", detail = ex.Message });
        }
    }
}
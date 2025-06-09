using Microsoft.AspNetCore.Mvc;
using Test2.DTOs;
using Test2.Services;

namespace Test2.Controllers;

[ApiController]
[Route("api/track-races")]
public class TrackRacesController : ControllerBase
{
    private readonly ITrackRacesService _trackRacesService;

    public TrackRacesController(ITrackRacesService trackRacesService)
    {
        _trackRacesService = trackRacesService;
    }

    [HttpPost("participants")]
    public async Task<IActionResult> AddNewRacersParticipations([FromBody] NewRacersParticipationsDTO dto, CancellationToken cancellationToken = default)
    {
        if (!ModelState.IsValid) return Conflict(ModelState);

        try
        {
            await _trackRacesService.AddNewRacersParticipations(dto, cancellationToken);
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { error = "Internal Server Error.", detail = ex.Message });
        }
    }
}
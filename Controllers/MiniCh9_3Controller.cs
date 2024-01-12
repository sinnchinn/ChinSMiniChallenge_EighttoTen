using ChinSMiniChallenge_EighttoTen.Services.MiniChallenge9_3;
using Microsoft.AspNetCore.Mvc;

namespace ChinSMiniChallenge_EighttoTen.Controllers;

[ApiController]
[Route("[controller]")]

public class MiniCh9_3Controller : ControllerBase
{
    private readonly IMiniCh9_3Service _miniCh9_3Service;

    public MiniCh9_3Controller(IMiniCh9_3Service miniCh9_3Service)
    {
        _miniCh9_3Service = miniCh9_3Service;
    }

    [HttpGet]
    [Route("HardMode/{hardGuess}")]
    

    public string HardMode(string hardGuess)
    {
        return _miniCh9_3Service.HardMode(hardGuess);
    }
}

using ChinSMiniChallenge_EighttoTen.Services.MiniChallenge9_2;
using Microsoft.AspNetCore.Mvc;

namespace ChinSMiniChallenge_EighttoTen.Controllers;

[ApiController]
[Route("[controller]")]

public class MiniCh9_2Controller : ControllerBase
{
    private readonly IMiniCh9_2Service _miniCh9_2Service;

    public MiniCh9_2Controller(IMiniCh9_2Service miniCh9_2Service)
    {
        _miniCh9_2Service = miniCh9_2Service;
    }

    [HttpGet]
    [Route("MediumMode/{medGuess}")]
    public string MediumMode(string medGuess)
    {
        return _miniCh9_2Service.MediumMode(medGuess);

    }
}

using ChinSMiniChallenge_EighttoTen.Services.MiniChallenge9_1;
using Microsoft.AspNetCore.Mvc;

namespace ChinSMiniChallenge_EighttoTen.Controllers;

[ApiController]
[Route("[controller]")]
public class MiniCh9_1Controller : ControllerBase
{
    private readonly IMiniCh9_1Service _miniCh9_1Service;

    public MiniCh9_1Controller(IMiniCh9_1Service miniCh9_1Service)
    {
        _miniCh9_1Service = miniCh9_1Service;
    }

    [HttpGet]
    [Route("EasyMode/{easyGuess}")]

    public string EasyMode(string easyGuess)
    {
        return _miniCh9_1Service.EasyMode(easyGuess);
    }

}

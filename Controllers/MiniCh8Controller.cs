using ChinSMiniChallenge_EighttoTen.Services.MiniChallenge8;
using Microsoft.AspNetCore.Mvc;

namespace ChinSMiniChallenge_EighttoTen.Controllers;

[ApiController]
[Route("[controller]")]

public class MiniCh8Controller : ControllerBase
{
    private readonly IMiniCh8Service _miniCh8Service;

    public MiniCh8Controller(IMiniCh8Service miniCh8Service)
    {
        _miniCh8Service = miniCh8Service;
    }


    [HttpGet]
    [Route("Magic8Ball")]

    public string Magic8Ball(string userQuestion)
    {
        return _miniCh8Service.Magic8Ball(userQuestion);
    }
    

}

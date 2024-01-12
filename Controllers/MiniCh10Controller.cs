using ChinSMiniChallenge_EighttoTen.Services.MiniChallenge10;
using Microsoft.AspNetCore.Mvc;

namespace ChinSMiniChallenge_EighttoTen.Controllers;

[ApiController]
[Route("[controller]")]

public class MiniCh10Controller : ControllerBase
{
    private readonly IMiniCh10Service _miniCh10Service;

    public MiniCh10Controller(IMiniCh10Service miniCh10Service)
    {
        _miniCh10Service = miniCh10Service;
    }
    [HttpGet]
    [Route("WhichAsianRestaurant/{inputAsian}")]

    public string WhichAsianRestaurant(string inputAsian)
    {
        return _miniCh10Service.WhichAsianRestaurant(inputAsian);
    }
}

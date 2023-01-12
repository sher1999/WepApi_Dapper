using Microsoft.AspNetCore.Mvc;
using Domain.Dtos;
using Infrastructure.Services;
namespace WebApi.Controllers;
    [ApiController]
[Route("[controller]")]


public class Task7Controller:ControllerBase
{
    private  Task7Service _task7Service;
    public Task7Controller() => _task7Service = new Task7Service();

    [HttpGet("Task7")]
    public List<GetTask7> GetTask7()
    {
        var orders = _task7Service.Orders();
        return orders;
    }
}

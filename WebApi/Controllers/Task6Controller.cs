using Microsoft.AspNetCore.Mvc;
using Domain.Dtos;
using Infrastructure.Services;
namespace WebApi.Controllers;
    [ApiController]
[Route("[controller]")]


public class Task6Controller:ControllerBase
{
    private  Task6Service _task6Service;
    public Task6Controller() => _task6Service = new Task6Service();

    [HttpGet("Task6")]
    public List<GetTask6> GetTasks6()
    {
        var orders = _task6Service.Orders();
        return orders;
    }
}

using Microsoft.AspNetCore.Mvc;
using Domain.Dtos;
using Infrastructure.Services;
namespace WebApi.Controllers;
    [ApiController]
[Route("[controller]")]


public class Task8Controller:ControllerBase
{
    private  Task8Service _task8Service;
    public Task8Controller() => _task8Service = new Task8Service();

    [HttpGet("Task8")]
    public List<GetTask8> GetTasks8()
    {
        var orders = _task8Service.Orders();
        return orders;
    }
}

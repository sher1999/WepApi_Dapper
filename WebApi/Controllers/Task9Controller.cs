using Microsoft.AspNetCore.Mvc;
using Domain.Dtos;
using Infrastructure.Services;
namespace WebApi.Controllers;
    [ApiController]
[Route("[controller]")]


public class Task9Controller:ControllerBase
{
    private  Task9Service _task9Service;
    public Task9Controller() => _task9Service = new Task9Service();

    [HttpGet("Task9")]
    public List<GetTask9> GetTasks9()
    {
        var orders = _task9Service.Orders();
        return orders;
    }
}

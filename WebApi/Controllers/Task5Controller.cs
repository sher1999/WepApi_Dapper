using Microsoft.AspNetCore.Mvc;
using Domain.Dtos;
using Infrastructure.Services;
namespace WebApi.Controllers;
    [ApiController]
[Route("[controller]")]


public class Task5Controller:ControllerBase
{
    private  Task5Service _task5Service;
    public Task5Controller()
    {
        _task5Service = new Task5Service();
    }   
    
    [HttpGet("Task5")]
    public List<GetTask5> GetTasks5()
    {
        var orders = _task5Service.Orders();
        return orders;
    }
}

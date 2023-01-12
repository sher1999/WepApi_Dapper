using Microsoft.AspNetCore.Mvc;
using Domain.Dtos;
using Infrastructure.Services;
namespace WebApi.Controllers;
    [ApiController]
[Route("[controller]")]


public class Task3Controller:ControllerBase
{
    private  Task3Service _task3Service;
    public Task3Controller()
    {
        _task3Service = new Task3Service();
    }   
    
    [HttpGet("Task3")]
    public List<GetTask3> GetTasks3()
    {
        var orders = _task3Service.Orders();
        return orders;
    }
}



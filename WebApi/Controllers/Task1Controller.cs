using Microsoft.AspNetCore.Mvc;
using Domain.Dtos;
using Infrastructure.Services;
namespace WebApi.Controllers;
    [ApiController]
[Route("[controller]")]


public class Task1Controller:ControllerBase
{
    private  Task1Service _task1Service;
    public Task1Controller()
    {
        _task1Service = new Task1Service();
    }   
    
    [HttpGet("Task1")]
    public List<GetTask1> GetTask1s()
    {
        var orders = _task1Service.Orders();
        return orders;
    }
}


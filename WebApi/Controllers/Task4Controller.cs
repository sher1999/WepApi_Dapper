using Microsoft.AspNetCore.Mvc;
using Domain.Dtos;
using Infrastructure.Services;
namespace WebApi.Controllers;
    [ApiController]
[Route("[controller]")]


public class Task4Controller:ControllerBase
{
    private  Task4Service _task4Service;
    public Task4Controller()
    {
        _task4Service = new Task4Service();
    }   
    
    [HttpGet("Task4")]
    public List<GetTask4> GetTasks4()
    {
        var orders = _task4Service.Orders();
        return orders;
    }
}

using Microsoft.AspNetCore.Mvc;
using Domain.Dtos;
using Infrastructure.Services;
namespace WebApi.Controllers;
    [ApiController]
[Route("[controller]")]

public class Task2Controller
{
      private  Task2Service _task1Service;
    public Task2Controller()
    {
        _task1Service = new Task2Service();
    }   
    
    [HttpGet("Task2")]
    public List<GetTask2> GetTask2s()
    {
        var orders = _task1Service.Orders();
        return orders;
    }
    

}

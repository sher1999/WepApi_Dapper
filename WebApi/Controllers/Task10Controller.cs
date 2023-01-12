using Microsoft.AspNetCore.Mvc;
using Domain.Dtos;
using Infrastructure.Services;
namespace WebApi.Controllers;
    [ApiController]
[Route("[controller]")]


public class Task10Controller:ControllerBase
{
    private  Task10Service _task10Service;
    public Task10Controller() => _task10Service = new Task10Service();

    [HttpGet("Task10")]
    public List<GetTask10> GetTasks10()
    {
        var orders = _task10Service.Orders();
        return orders;
    }
}

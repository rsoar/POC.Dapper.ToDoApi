using Microsoft.AspNetCore.Mvc;
using POC.Dapper.ToDoApi.Domain;
using POC.Dapper.ToDoApi.Domain.Entities;
using POC.Dapper.ToDoApi.Presentation.DTO;

namespace POC.Dapper.ToDoApi.Presentation.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TodoController : ControllerBase
    {
        private readonly TodoService _todoService;
        public TodoController(TodoService todoService)
        {
            _todoService = todoService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            List<Todo> todos = _todoService.ToList();

            return Ok(todos);
        }

        [HttpPost]
        public IActionResult Post([FromBody] CreateTodo dto)
        {
            _todoService.Create(dto);
            List<Todo> todos = _todoService.ToList();

            return Ok(todos);
        }
    }
}
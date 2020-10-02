using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TodoApp.Application;
using TodoApp.Application.Commands.Todo;
using TodoApp.Application.DataTransfer;
using TodoApp.Application.Queries.Todo;
using TodoApp.Application.Searches;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TodoApp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodosController : ControllerBase
    {
        private readonly UseCaseExecutor _executor;

        public TodosController(UseCaseExecutor executor)
        {
            _executor = executor;
        }

        // GET: api/<TodosController>
        [HttpGet]
        public IActionResult Get(
            [FromQuery] TodoSearch search,
            [FromServices] IGetTodosQuery query)
        {
            return Ok(_executor.ExecuteQuery(query, search));
        }

        // GET api/<TodosController>/5
        [HttpGet("{id}")]
        public IActionResult Get(
            int id,
            [FromServices] IGetSingleTodoQuery query)
        {
            return Ok(_executor.ExecuteQuery(query, id));
        }

        // POST api/<TodosController>
        [HttpPost]
        public IActionResult Post(
            [FromBody] TodoDto todo,
            [FromServices] IAddTodoCommand command)
        {
            _executor.ExecuteCommand(command, todo);

            return NoContent();
        }

        // PUT api/<TodosController>/5
        [HttpPut("{id}")]
        public IActionResult Put(
            int id,
            [FromBody] TodoDto todo,
            [FromServices] IUpdateTodoCommand command)
        {
            todo.Id = id;
            _executor.ExecuteCommand(command, todo);

            return NoContent();
        }

        // DELETE api/<TodosController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(
            int id,
            [FromServices] IDeleteTodoCommand command)
        {
            _executor.ExecuteCommand(command, id);

            return NoContent();
        }
    }
}

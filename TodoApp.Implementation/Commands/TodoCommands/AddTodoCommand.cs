using System;
using System.Collections.Generic;
using System.Text;
using TodoApp.Application.Commands.Todo;
using TodoApp.Application.DataTransfer;
using TodoApp.DataAccess;
using TodoApp.Domain;

namespace TodoApp.Implementation.Commands.TodoCommands
{
    public class AddTodoCommand : IAddTodoCommand
    {
        private readonly TodoAppContext _context;
        public AddTodoCommand(TodoAppContext context)
        {
            _context = context;
        }
        public int Id => 1;

        public string Name => "Add todo command";

        public void Execute(TodoDto request)
        {
            Todo todo = new Todo
            {
                Name = request.Name,
                Description = request.Description,
                Status = request.Status
            };

            _context.Todos.Add(todo);
            _context.SaveChanges();
        }
    }
}

using FluentValidation;
using TodoApp.Application.Commands.Todo;
using TodoApp.Application.DataTransfer;
using TodoApp.DataAccess;
using TodoApp.Domain;
using TodoApp.Implementation.Validators;

namespace TodoApp.Implementation.Commands.TodoCommands
{
    public class AddTodoCommand : IAddTodoCommand
    {
        private readonly TodoAppContext _context;
        private readonly CreateTodoValidator _validator;

        public AddTodoCommand(
            TodoAppContext context,
            CreateTodoValidator validator)
        {
            _context = context;
            _validator = validator;
        }
        public int Id => 1;

        public string Name => "Add todo command";

        public void Execute(TodoDto request)
        {
            _validator.ValidateAndThrow(request);

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

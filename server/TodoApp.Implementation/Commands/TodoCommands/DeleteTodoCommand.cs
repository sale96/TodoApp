using TodoApp.Application.Commands.Todo;
using TodoApp.DataAccess;
using TodoApp.Application.Exceptions;
using TodoApp.Domain;

namespace TodoApp.Implementation.Commands.TodoCommands
{
    public class DeleteTodoCommand : IDeleteTodoCommand
    {
        private readonly TodoAppContext _context;

        public DeleteTodoCommand(TodoAppContext context)
        {
            _context = context;
        }

        public int Id => 3;

        public string Name => "Delete Todo command";

        public void Execute(int request)
        {
            var todo = _context.Todos.Find(request);

            if (todo == null)
                throw new EntityNotFoundException(request, typeof(Todo));

            _context.Todos.Remove(todo);
            _context.SaveChanges();
        }
    }
}

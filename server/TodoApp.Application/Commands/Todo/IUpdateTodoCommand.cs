using TodoApp.Application.DataTransfer;

namespace TodoApp.Application.Commands.Todo
{
    public interface IUpdateTodoCommand : ICommand<TodoDto>
    {
    }
}

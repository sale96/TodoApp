using TodoApp.Application.DataTransfer;

namespace TodoApp.Application.Queries.Todo
{
    public interface IGetSingleTodoQuery : IQuery<int, TodoDto>
    {
    }
}

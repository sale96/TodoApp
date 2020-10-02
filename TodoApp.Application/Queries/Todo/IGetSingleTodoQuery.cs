using System;
using System.Collections.Generic;
using System.Text;
using TodoApp.Application.DataTransfer;

namespace TodoApp.Application.Queries.Todo
{
    public interface IGetSingleTodoQuery : IQuery<int, TodoDto>
    {
    }
}

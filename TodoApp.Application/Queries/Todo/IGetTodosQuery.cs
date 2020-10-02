using System;
using System.Collections.Generic;
using System.Text;
using TodoApp.Application.DataTransfer;
using TodoApp.Application.Searches;

namespace TodoApp.Application.Queries.Todo
{
    public interface IGetTodosQuery : IQuery<TodoSearch, PagedResponse<TodoDto>>
    {
    }
}

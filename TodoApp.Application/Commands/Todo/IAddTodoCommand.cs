using System;
using System.Collections.Generic;
using System.Text;
using TodoApp.Application.DataTransfer;

namespace TodoApp.Application.Commands.Todo
{
    public interface IAddTodoCommand : ICommand<TodoDto>
    {
    }
}

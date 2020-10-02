using System;
using System.Collections.Generic;
using System.Text;
using TodoApp.Application.DataTransfer;
using TodoApp.Application.Exceptions;
using TodoApp.Application.Queries.Todo;
using TodoApp.DataAccess;
using TodoApp.Domain;

namespace TodoApp.Implementation.Queries
{
    public class GetSingleTodoQuery : IGetSingleTodoQuery
    {
        private readonly TodoAppContext _context;

        public GetSingleTodoQuery(TodoAppContext context)
        {
            _context = context;
        }

        public int Id => 5;

        public string Name => "Get single todo query";

        public TodoDto Execute(int search)
        {
            var todo = _context.Todos.Find(search);

            if (todo == null)
                throw new EntityNotFoundException(search, typeof(Todo));

            var dto = new TodoDto
            {
                Name = todo.Name,
                Description = todo.Description,
                IsFinished = todo.IsFinished,
                Status = todo.Status,
                Id = todo.Id
            };

            return dto;
        }
    }
}

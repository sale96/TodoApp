using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TodoApp.Application.Commands.Todo;
using TodoApp.Application.DataTransfer;
using TodoApp.Application.Exceptions;
using TodoApp.DataAccess;
using TodoApp.Domain;
using TodoApp.Implementation.Validators;

namespace TodoApp.Implementation.Commands.TodoCommands
{
    public class UpdateTodoCommand : IUpdateTodoCommand
    {
        private readonly TodoAppContext _context;
        private readonly UpdateTodoValidator _validator;
        public UpdateTodoCommand(
            TodoAppContext context,
            UpdateTodoValidator validator)
        {
            _context = context;
            _validator = validator;
        }

        public int Id => 2;

        public string Name => "Update todo command";

        public void Execute(TodoDto request)
        {
            _validator.ValidateAndThrow(request);

            var todo = _context.Todos.FirstOrDefault(x => x.Id == request.Id);

            if (todo == null)
            {
                throw new EntityNotFoundException(request.Id, typeof(Todo));
            }

            todo.Name = request.Name;
            todo.Description = request.Description;
            todo.IsFinished = request.IsFinished;
            todo.Status = request.Status;

            _context.Todos.Update(todo);
            _context.SaveChanges();
        }
    }
}

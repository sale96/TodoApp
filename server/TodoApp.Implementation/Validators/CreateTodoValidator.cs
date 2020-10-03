using TodoApp.Application.DataTransfer;
using FluentValidation;
using TodoApp.DataAccess;
using System.Linq;

namespace TodoApp.Implementation.Validators
{
    public class CreateTodoValidator : AbstractValidator<TodoDto>
    {
        public CreateTodoValidator(TodoAppContext context)
        {
            RuleFor(x => x.Name)
                .NotEmpty()
                .Must(name => !context.Todos.Any(t => t.Name == name))
                .WithMessage("Todo must be unique!");
        }
    }
}

﻿using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TodoApp.Application.DataTransfer;
using TodoApp.DataAccess;

namespace TodoApp.Implementation.Validators
{
    public class UpdateTodoValidator : AbstractValidator<TodoDto>
    {
        public UpdateTodoValidator(TodoAppContext context)
        {
            RuleFor(x => x.Name)
                .NotEmpty()
                .Must((dto, name) => !context.Todos.Any(t => t.Name == name && t.Id != dto.Id))
                .WithMessage("Todo name must be unique!");
        }
    }
}

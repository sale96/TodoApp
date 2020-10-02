using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoApp.Application.Commands.Todo;
using TodoApp.Implementation.Commands.TodoCommands;

namespace TodoApp.Api.Services
{
    public static class CommandServices
    {
        public static IServiceCollection AddCommandServices(this IServiceCollection services)
        {
            services.AddTransient<IAddTodoCommand, AddTodoCommand>();
            services.AddTransient<IUpdateTodoCommand, UpdateTodoCommand>();
            services.AddTransient<IDeleteTodoCommand, DeleteTodoCommand>();

            return services;
        }
    }
}

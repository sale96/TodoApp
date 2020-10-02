using Microsoft.Extensions.DependencyInjection;
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

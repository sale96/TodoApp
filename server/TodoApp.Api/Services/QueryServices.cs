using Microsoft.Extensions.DependencyInjection;
using TodoApp.Application.Queries.Todo;
using TodoApp.Implementation.Queries;

namespace TodoApp.Api.Services
{
    public static class QueryServices
    {
        public static IServiceCollection AddQueryServices(this IServiceCollection services)
        {
            services.AddTransient<IGetTodosQuery, GetTodosQuery>();
            services.AddTransient<IGetSingleTodoQuery, GetSingleTodoQuery>();

            return services;
        }
    }
}

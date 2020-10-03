using Microsoft.Extensions.DependencyInjection;
using TodoApp.Implementation.Validators;

namespace TodoApp.Api.Services
{
    public static class ValidationServices
    {
        public static IServiceCollection AddValidationServices(this IServiceCollection services)
        {
            services.AddTransient<CreateTodoValidator>();
            services.AddTransient<UpdateTodoValidator>();

            return services;
        }
    }
}

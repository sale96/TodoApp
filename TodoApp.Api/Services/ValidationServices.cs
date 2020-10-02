using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoApp.Implementation.Validators;

namespace TodoApp.Api.Services
{
    public static class ValidationServices
    {
        public static IServiceCollection AddValidationServices(this IServiceCollection services)
        {
            services.AddTransient<CreateTodoValidator>();
            return services;
        }
    }
}

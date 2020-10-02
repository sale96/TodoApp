using Newtonsoft.Json;
using System;
using TodoApp.Application;

namespace TodoApp.Implementation.Logging
{
    public class ConsoleUseCaseLogger : IUseCaseLogger
    {
        public void Log(IUseCase useCase, object useCaseData)
        {
            Console.WriteLine($"{ DateTime.Now }: Trying to execute { useCase.Name } with data: { JsonConvert.SerializeObject(useCaseData) }");
        }
    }
}

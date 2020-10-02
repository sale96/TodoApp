using System;
using System.Collections.Generic;
using System.Text;

namespace TodoApp.Application
{
    public class UseCaseExecutor
    {
        private readonly IUseCaseLogger _logger;
        public UseCaseExecutor(IUseCaseLogger logger)
        {
            _logger = logger;
        }

        public void ExecuteCommand<TRequest>(
            ICommand<TRequest> command,
            TRequest request)
        {
            _logger.Log(command, request);
            command.Execute(request);
        }
    }
}

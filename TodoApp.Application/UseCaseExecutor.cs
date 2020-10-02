using System;
using System.Collections.Generic;
using System.Text;

namespace TodoApp.Application
{
    public class UseCaseExecutor
    {
        public UseCaseExecutor()
        {
        }

        public void ExecuteCommand<TRequest>(
            ICommand<TRequest> command,
            TRequest request)
        {
            command.Execute(request);
        }
    }
}

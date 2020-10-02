using System;
using System.Collections.Generic;
using System.Text;

namespace TodoApp.Application
{
    public interface IUseCaseLogger
    {
        void Log(IUseCase useCase, object useCaseData);
    }
}

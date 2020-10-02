using System;
using System.Collections.Generic;
using System.Text;

namespace TodoApp.Application
{
    public interface IUseCase
    {
        int Id { get; }
        string Name { get; }
    }
}

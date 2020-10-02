using System;
using System.Collections.Generic;
using System.Text;
using TodoApp.Domain;

namespace TodoApp.Application.DataTransfer
{
    public class TodoDto : BaseDto
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public TodoStatus Status { get; set; }
    }
}

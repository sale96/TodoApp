using System;

namespace TodoApp.Domain
{
    public class Todo : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsFinished { get; set; }
        public TodoStatus Status { get; set; }
    }

    public enum TodoStatus
    {
        LowPriority,
        MediumPriority,
        HighPriority
    }
}

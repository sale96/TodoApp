using TodoApp.Domain;

namespace TodoApp.Application.DataTransfer
{
    public class TodoDto : BaseDto
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsFinished { get; set; } = false;
        public TodoStatus Status { get; set; }
    }
}

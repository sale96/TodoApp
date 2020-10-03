using TodoApp.Application.Queries;

namespace TodoApp.Application.Searches
{
    public class TodoSearch : PagedSearch
    {
        public string Name { get; set; }
    }
}

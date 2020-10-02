using System.Linq;
using TodoApp.Application.DataTransfer;
using TodoApp.Application.Queries;
using TodoApp.Application.Queries.Todo;
using TodoApp.Application.Searches;
using TodoApp.DataAccess;

namespace TodoApp.Implementation.Queries
{
    public class GetTodosQuery : IGetTodosQuery
    {
        private readonly TodoAppContext _context;

        public GetTodosQuery(TodoAppContext context)
        {
            _context = context;
        }

        public int Id => 4;

        public string Name => "Get all todos query";

        public PagedResponse<TodoDto> Execute(TodoSearch search)
        {
            var query = _context.Todos.AsQueryable();

            if (!string.IsNullOrEmpty(search.Name) || !string.IsNullOrWhiteSpace(search.Name))
                query = query.Where(x => x.Name.ToLower().Contains(search.Name));

            var skipCount = search.PerPage * (search.Page - 1);

            var response = new PagedResponse<TodoDto>
            {
                CurrentPage = search.Page,
                ItemsPerPage = search.PerPage,
                TotalCount = query.Count(),
                Items = query.Skip(skipCount).Take(search.PerPage).Select(x =>
                    new TodoDto
                    {
                        Id = x.Id,
                        Name = x.Name,
                        Description = x.Description,
                        IsFinished = x.IsFinished,
                        Status = x.Status
                    }).ToList()
            };

            return response;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using TodoApp.Application.Queries;

namespace TodoApp.Application.Searches
{
    public class TodoSearch : PagedSearch
    {
        public string Name { get; set; }
    }
}

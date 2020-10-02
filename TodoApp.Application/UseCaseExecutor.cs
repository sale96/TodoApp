namespace TodoApp.Application
{
    public class UseCaseExecutor
    {
        private readonly IUseCaseLogger _logger;
        public UseCaseExecutor(IUseCaseLogger logger)
        {
            _logger = logger;
        }

        public TResult ExecuteQuery<TSearch, TResult>(
            IQuery<TSearch, TResult> query,
            TSearch search)
        {
            _logger.Log(query, search);
            return query.Execute(search);
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

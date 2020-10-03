namespace TodoApp.Application
{
    public interface IUseCaseLogger
    {
        void Log(IUseCase useCase, object useCaseData);
    }
}

namespace Applinate.Internals
{
    public static class RequestExecutorHelper
    {
        public static void Register()
        {
            ServiceProvider.Register<IRequestExecutor>(() => new RequestExecutor());
        }
    }
}
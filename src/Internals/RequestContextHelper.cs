namespace Applinate.Internals
{
    public static class RequestContextHelper
    {
        public static void SetCurrentRequestContext(this RequestContext ctx) =>
            RequestContextProvider.Instance = ctx;

        public static RequestContext GetCurrentRequestContext() =>
            RequestContextProvider.Instance;

        internal static void SetCurrentRequestContextAsClient() =>
           RequestContextProvider.Instance = RequestContextProvider.Instance with 
            { 
                ServiceType = ServiceType.Client 
            };
    }
}
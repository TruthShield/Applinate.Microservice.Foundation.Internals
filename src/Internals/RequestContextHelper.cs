namespace Applinate.Internals
{
    public static class RequestContextHelper
    {
        public static void SetCurrentRequestContext(this RequestContext ctx) =>
            RequestContext.Current = ctx;

        public static RequestContext GetCurrentRequestContext() => 
            RequestContext.Current;

        internal static void SetCurrentRequestContextAsClient() =>
            RequestContext.Current = RequestContext.Current with 
            { 
                ServiceType = ServiceType.Client 
            };
    }
}
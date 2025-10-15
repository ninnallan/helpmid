namespace Midterm.Middleware
{
    public class LogRequestMiddleware
    {
        private RequestDelegate _next;

        public LogRequestMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            Console.WriteLine($"Request Method: {context.Request.Method}");

            Console.WriteLine($"Request Path: {context.Request.Path}");

            await _next(context);
        }
    }
}

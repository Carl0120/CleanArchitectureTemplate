namespace Api.Middlewares;

public class ExceptionHandlerMiddleware : IMiddleware
{
    private ILogger<ExceptionHandlerMiddleware> _logger;

    public ExceptionHandlerMiddleware(ILogger<ExceptionHandlerMiddleware> logger)
    {
        _logger = logger;
    }

    public async Task InvokeAsync(HttpContext context, RequestDelegate next)
    {
        try
        {
            await next(context);
        }
        catch (Exception e)
        {
            _logger.LogError(e, e.Message);
            await HandleExceptionAsync(context, e);
        }
    
    }

    private async Task HandleExceptionAsync(HttpContext context, Exception exception)
    {
        
    }
}
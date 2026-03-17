using System.Net;

namespace WebApiDemo.Authen.Exceptions
{
    public class GlobalExceptionHandler 
    {
        private readonly ILogger<GlobalExceptionHandler> _logger;   

        public GlobalExceptionHandler(ILogger<GlobalExceptionHandler> logger)
        {
            _logger = logger;
        }

        public async ValueTask<bool> TryHandleAsync(HttpContext httpContext, Exception exception, CancellationToken cancellation)
        {
            var (statuCode, message) = GetExceptionDetails(exception);

            _logger.LogError(exception, exception.Message);

            httpContext.Response.StatusCode = (int)statuCode;
            await httpContext.Response.WriteAsJsonAsync(message, cancellation);

            return true;
        }
        private (HttpStatusCode statusCode, string message) GetExceptionDetails(Exception exception)
        {
            return exception switch
            {
                LoginFailedException => (HttpStatusCode.Unauthorized, exception.Message),
                UserAlreadyExistsException => (HttpStatusCode.Conflict, exception.Message),
                RegistrationFailedException => (HttpStatusCode.BadRequest, exception.Message),
                RefreshTokenException => (HttpStatusCode.Unauthorized, exception.Message),
                _=> (HttpStatusCode.InternalServerError,$"An unexpected error ocurred:{exception.Message}"),

            };
        }
    }
}

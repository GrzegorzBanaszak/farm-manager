using FluentValidation;
using System.Net;
using System.Text.Json;

namespace farm_manager.API.Middleware
{
    public class ExceptionHandlingMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger<ExceptionHandlingMiddleware> _logger;

        public ExceptionHandlingMiddleware(RequestDelegate next, ILogger<ExceptionHandlingMiddleware> logger)
        {
            _next = next;
            _logger = logger;
        }

        public async Task Invoke(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (ValidationException ex)
            {
                context.Response.StatusCode = (int)HttpStatusCode.BadRequest;
                context.Response.ContentType = "application/json";

                var errors = ex.Errors
                    .Select(e => new { e.PropertyName, e.ErrorMessage })
                    .ToList();

                var json = JsonSerializer.Serialize(new
                {
                    Message = "Validation failed",
                    Errors = errors
                });

                await context.Response.WriteAsync(json);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Unexpected error occurred.");

                context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
                context.Response.ContentType = "application/json";

                var json = JsonSerializer.Serialize(new
                {
                    Message = "Internal server error",
                    Details = ex.Message
                });

                await context.Response.WriteAsync(json);
            }
        }
    }
}

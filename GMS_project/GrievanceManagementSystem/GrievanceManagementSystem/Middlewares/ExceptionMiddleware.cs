using Microsoft.AspNetCore.Diagnostics;

namespace GrievanceManagementSystem.Middlewares
{
    /// <summary>
    /// Handles unexpected exceptions globally.
    /// </summary>
    public static class ExceptionMiddleware
    {
        public static void ConfigureExceptionHandler(this WebApplication app)
        {
            app.UseExceptionHandler(errorApp =>
            {
                errorApp.Run(async context =>
                {
                    context.Response.StatusCode = StatusCodes.Status500InternalServerError;

                    var exception = context.Features.Get<IExceptionHandlerFeature>();

                    if (exception != null)
                    {
                        await context.Response.WriteAsync(
                            "An unexpected error occurred.");
                    }
                });
            });
        }
    }
}
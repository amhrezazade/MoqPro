using Microsoft.Extensions.Primitives;

namespace MoqProServer.Middleware;

public class AuthMiddleware(RequestDelegate next)
{
    public async Task InvokeAsync(HttpContext context)
    {
        if (context.Request.Path.StartsWithSegments("api"))
        {
            StringValues val;
            if (context.Request.Headers.TryGetValue("apikey", out val))
            {
                // TODO
            }
            else
            {
                var response = "no access";
                await context.Response.WriteAsync(response);
                context.Response.StatusCode = 401;
                return;
            }
        }

        await next(context);
    }
}


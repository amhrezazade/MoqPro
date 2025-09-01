using MoqProDomain.Service;
using Newtonsoft.Json;
using System.Globalization;
using System.IO;

namespace MoqProServer.Middleware;

public class MainMiddleware(RequestDelegate next, RequestHandlerService handler)
{
    public async Task InvokeAsync(HttpContext context)
    {
        var path = context.Request.Path.Value ?? "/";

        if (handler.CanHandlePath(path))
        {
            var response = handler.Handle(path);
            context.Response.ContentType = "application/json";
            await context.Response.WriteAsync(JsonConvert.SerializeObject(response, Formatting.Indented));
        }
        else
        {
            await next(context);
        }
    }
}


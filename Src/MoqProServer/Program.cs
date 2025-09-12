using MoqProDomain.Service;
using MoqProServer.Middleware;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSingleton<RequestHandlerService>();

DataService dataService = new DataService();
dataService.Init();
builder.Services.AddSingleton(dataService);

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseMiddleware<MainMiddleware>();
app.MapControllers();
app.Run();

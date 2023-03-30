var builder = WebApplication.CreateBuilder(args);

//DI - dependency injection
//builder.Services.AddDbContext<ApplicationDbContext>(); // ��������� DbContext � IoC-���������

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.MapGet("/ping", async(context) => 
{
    await context.Response.WriteAsync("pong");
});

app.Run();

using RestWithASPNET10Erudio.Model;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddOpenApi();

builder.Services.AddControllers();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

// Expose root endpoint returning the same Greeting so http://localhost:5171/ responds
app.MapGet("/", () => new Greeting(1, "Hello World from ASP.NET Core 10!"));

app.MapControllers();

app.Run();

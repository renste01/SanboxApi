using LinqToDB;
using Infrastructure.Data;
using LinqToDB.AspNet;
using Service;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddOpenApi();

builder.Services.AddLinqToDBContext<AppDataConnection>((provider, options) =>
    options.UseSQLite(builder.Configuration.GetConnectionString("Default") ?? "Data Source=app.db"));

builder.Services.AddScoped<ProductService>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseAuthorization();
app.MapControllers();

app.Run();

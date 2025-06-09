using Microsoft.EntityFrameworkCore;
using Test2.Data;
using Test2.Repositories;
using Test2.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddDbContext<DatabaseContext>(options => 
    options.UseSqlServer(builder.Configuration.GetConnectionString("Default"))
);

builder.Services.AddScoped<IRacersService, RacersService>();
builder.Services.AddScoped<IRacersRepository, RacersRepository>();

var app = builder.Build();

app.UseAuthorization();

app.MapControllers();

await app.RunAsync();
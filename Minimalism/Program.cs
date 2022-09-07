using FastEndpoints;
using Minimalism.Application.Repositories;
using Minimalism.Database;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddFastEndpoints();

builder.Services.AddDbContext<DatabaseContext>();
builder.Services.AddScoped<IParkingRepository, ParkingRepository>();
builder.Services.AddScoped<IParkingSpotRepository, ParkingSpotRepository>();

var app = builder.Build();
app.UseFastEndpoints();

app.Run();
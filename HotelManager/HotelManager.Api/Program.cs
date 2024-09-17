using HotelManager.Api.Context;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddDbContext<RoomsContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("Default connection")));

builder.Services.AddControllers();


var app = builder.Build();

app.Run();

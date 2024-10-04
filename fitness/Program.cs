using FastEndpoints;
using fitness.Data;
using fitness.Services.Users;
using Microsoft.EntityFrameworkCore;
using FluentValidation;
using fitness.Interfaces;
using fitness.Services;

var bld = WebApplication.CreateBuilder();
bld.Services.AddFastEndpoints();
bld.Services.AddControllers();

bld.Services.AddDbContext<DataContext>(options => {
    options.UseNpgsql(bld.Configuration.GetConnectionString("WebApiDatabase"));
});

bld.Services.AddScoped<IUserService, UserService>();
bld.Services.AddScoped<IGymService, GymService>();


var app = bld.Build();
app.UseFastEndpoints();
app.MapControllers();
app.UseHttpsRedirection();
app.Run();

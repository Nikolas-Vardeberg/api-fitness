using FastEndpoints;
using fitness.Data;
using fitness.Models.Users;
using Microsoft.EntityFrameworkCore;

var bld = WebApplication.CreateBuilder();
bld.Services.AddFastEndpoints();

bld.Services.AddDbContext<DataContext>(options => {
    options.UseNpgsql(bld.Configuration.GetConnectionString("WebApiDatabase"));
});

var app = bld.Build();
app.UseFastEndpoints();
app.Run();

using LandSoft.API.BuilderExtensions;
using LandSoft.Data.EF;
using LandSoft.Data.EF.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

#region Register service 
builder.Services.AddDbContext<LSDbContext>(option => option.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"), 
                                                                        o => o.MigrationsAssembly("LandSoft.Data.EF")));
builder.Services.ConfigureIdentity();
builder.Services.ConfigureMapper();
#endregion Register service

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
	app.UseSwagger();
	app.UseSwaggerUI();
}

using(var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    var context = services.GetRequiredService<LSDbContext>();
    var initializer = services.GetRequiredService<DbInitializer>();
    initializer.Seed().Wait();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

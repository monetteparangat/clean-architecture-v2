using CleanArchitecture.Infrastructure.Data.Context;
using CleanArchitecture.Infrastructure.IoC;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//AddDbContext
var universityDbConnectionString = builder.Configuration.GetConnectionString("UniversityDbConnection") ?? throw new InvalidOperationException("Connection String 'UniversityDbConnection' not found");

builder.Services.AddDbContext<UniversityDbContext>(options =>
    options.UseMySql(universityDbConnectionString, ServerVersion.AutoDetect(universityDbConnectionString)));

//Register services
DependencyContainer.RegisterServices(builder.Services);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

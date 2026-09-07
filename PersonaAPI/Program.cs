using Microsoft.EntityFrameworkCore;
using PersonaAPI.Models;

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("PersonasDbContext") ?? throw new InvalidOperationException("Connection string 'PersonasDbContext' not found.");
builder.Services.AddDbContext<PersonasDbContext>(options =>
    options.UseInMemoryDatabase("PersonasInMemoryDB"));
// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddSwaggerGen();
builder.Services.AddOpenApi();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

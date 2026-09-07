using LibrosAPI.Models;
using Microsoft.EntityFrameworkCore;
using StackExchange.Redis;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

//builder.Services.AddDbContext<LibrosDbContext>(options =>
//    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddDbContext<LibrosDbContext>(options =>
    options.UseInMemoryDatabase("LibrosInMemoryDB"));
builder.Services.AddStackExchangeRedisCache(options =>
{
    options.Configuration =
builder.Configuration.GetConnectionString("RedisConnection");
});

builder.Services.AddSingleton<IConnectionMultiplexer>(sp =>
{
    var configuration =
ConfigurationOptions.Parse(builder.Configuration.GetConnectionString("RedisConnection")!, true);
    return ConnectionMultiplexer.Connect(configuration);
});

builder.Services.AddOutputCache();
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

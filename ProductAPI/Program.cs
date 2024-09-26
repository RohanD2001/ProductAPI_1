using ProductAPI.Data;
using ProductAPI.Repositories;
using Microsoft.EntityFrameworkCore;
using Polly;
using ProductAPI.Middleware;
using ProductAPI.EventHandler;
using Polly.Extensions.Http;

var builder = WebApplication.CreateBuilder(args);

// Adding services
builder.Services.AddControllers();
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddTransient<IProductRepository, ProductRepository>();
builder.Services.AddSingleton<ProductCreatedEventHandler>();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();



var app = builder.Build();


if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseMiddleware<CustomMiddleware>(); // Registering custom middleware
app.UseMiddleware<ExceptionHandlingMiddleware>(); // Registering exception handling middleware

app.UseHttpsRedirection();
app.MapControllers();
app.Run();

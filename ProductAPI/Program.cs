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

static IAsyncPolicy<HttpResponseMessage> GetRetryPolicy()
{
    return HttpPolicyExtensions
        .HandleTransientHttpError()
        .OrResult(msg => msg.StatusCode == System.Net.HttpStatusCode.NotFound)
        .WaitAndRetryAsync(3, retryAttempt => TimeSpan.FromSeconds(Math.Pow(2, retryAttempt)));
}

builder.Services.AddHttpClient("MyClient")
    .SetHandlerLifetime(TimeSpan.FromMinutes(5))
    .AddPolicyHandler(GetRetryPolicy());

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseMiddleware<CustomMiddleware>(); // Register custom middleware
app.UseMiddleware<ExceptionHandlingMiddleware>(); // Register exception handling middleware

app.UseHttpsRedirection();
app.MapControllers();
app.Run();

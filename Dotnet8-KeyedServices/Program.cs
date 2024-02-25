using Dotnet8_KeyedServices;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IShoppingCartRepository, ShoppingCartRepository>();

builder.Services.AddKeyedScoped<IShoppingCart,ShoppingCartCache>(CartSource.Cache);
builder.Services.AddKeyedScoped<IShoppingCart, ShoppingCartDB>(CartSource.DB);
builder.Services.AddKeyedScoped<IShoppingCart, ShoppingCartAPI>(CartSource.API);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();

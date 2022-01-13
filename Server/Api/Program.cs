using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SharedModels.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<ICartRepository, CartRepository>();

builder.Services.AddDbContext<ShopContext>(opts => opts.UseSqlite($"Data Source={AppContext.BaseDirectory}{System.IO.Path.DirectorySeparatorChar}shop.db"));

//var mockDbOptions = new DbContextOptionsBuilder<ShopMockContext>()
//    .UseInMemoryDatabase(databaseName: "ShopMockDataBase")
//    .Options;
//builder.Services.AddDbContext<ShopMockContext>(opts => opts.UseInMemoryDatabase("ShopMockDataBase"));

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

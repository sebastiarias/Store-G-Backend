using FluentValidation.AspNetCore;
using Microsoft.EntityFrameworkCore;
using StoregApp.Application;
using StoregApp.Application.Interfaces;
using StoregApp.Application.Responses;
using StoregApp.Application.Services;
using StoregApp.Domain.Interfaces;
using StoregApp.Infrastructure.Persistence;
using StoregApp.Infrastructure.Repositories;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddFluentValidation();
builder.Services.AddAplicationServices();
builder.Services.AddTransient<ICategoryRepository, CategoryRepository>();
builder.Services.AddTransient<ICustomerRepository, CustomerRepository>();
builder.Services.AddTransient<IOrderDetailRepository, OrderDetailRepository>();
builder.Services.AddTransient<IOrderRepository, OrderRepository>();
builder.Services.AddTransient<IProductRepository, ProductRepository>();
//Se agrega conexion interfaces de services
builder.Services.AddTransient<ICategoryService, CategoryService>();


builder.Services.AddDbContext<StoreGContext>(options => options.UseSqlServer("name=ConnectionStrings:StoreG"));
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo
    {
        Title = "Storeg Api",
        Description = "Estos son los endpoinsts del Api"
    });
    string? nombreArchivo = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
    var xmlPath = Path.Combine(AppContext.BaseDirectory, nombreArchivo);
    options.IncludeXmlComments(xmlPath);
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(options =>
    {
        options.SwaggerEndpoint("/swagger/v1/swagger.json", "Storeg Api v1");
        options.RoutePrefix = String.Empty;
    });
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

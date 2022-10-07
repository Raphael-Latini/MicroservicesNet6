using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.SqlServer.Management.HadrData;
using Microsoft.SqlServer.Management.Smo;
using Microsoft.SqlServer.Management.Smo.Wmi;
using Shopping.ProductAPI.Config;
using Shopping.ProductAPI.Model.Context;
using Shopping.ProductAPI.Repository;

var builder = WebApplication.CreateBuilder(args);




builder.Services.AddDbContext<SqlServerContext>(
       options => options.UseSqlServer
       ("Data Source = RAPHAEL-LATINI\\SQLEXPRESS; Initial Catalog = shopping_product_api; Integrated Security = True"));

IMapper mapper = MappingConfig.RegisterMaps().CreateMapper();
builder.Services.AddSingleton(mapper);
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

builder.Services.AddScoped<IProductRepository, ProductRepository>();
// Add services to the container.
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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

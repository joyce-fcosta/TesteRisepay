using Domain.Interfaces;
using Domain.Interfaces.Generics;
using Domain.Services;
using Infra.Configuration;
using Infra.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

builder.Services.AddControllersWithViews();
builder.Services.AddSwaggerGen(c =>
{
	c.SwaggerDoc("v1", new OpenApiInfo { Title = "WebAPI", Version = "v1" });
});

builder.Services.AddDbContext<ContextBase>(option => option.UseMySQL(builder.Configuration.GetConnectionString("MySQL")));


//Injeção de dependência
builder.Services.AddSingleton(typeof(IGenerics<>), typeof(RepositoryGenerics<>));

builder.Services.AddSingleton<ICargo, RepositoryCargo>();
builder.Services.AddSingleton<IColaboradores, RepositoryColaboradores>();

builder.Services.AddSingleton<IServiceCargo, ServiceCargo>();
builder.Services.AddSingleton<IServiceColaborador, ServiceColaborador>();
var app = builder.Build();


if (app.Environment.IsDevelopment())
{
	app.UseSwagger();
	app.UseSwaggerUI();
}

app.UseCors(x =>
x.AllowAnyOrigin()
.AllowAnyMethod()
.AllowAnyHeader()
.WithOrigins());

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();

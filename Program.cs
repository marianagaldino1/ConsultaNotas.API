using ConsultaNotas.API;
using ConsultaNotas.Application.Services.Implentations;
using ConsultaNotas.Application.Services.Interfaces;
using ConsultaNotas.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.OpenApi.Models;
using System;

var builder = WebApplication.CreateBuilder(args);
//builder.Services.Configure<OpeningTimeOption>(Configuration.GetSection("OpeningTime"));


builder.Services.AddDbContext<ConsultaNotasDbContext>(options => options.UseInMemoryDatabase("ConsultaNotas"));

builder.Services.AddScoped<IAlunoService, AlunoService>();
builder.Services.AddControllers();


builder.Services.AddEndpointsApiExplorer();// Add services to the container.

builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo
    { Title = "ConsultaNotas.API", Version = "v1" });
});



var app = builder.Build();


// Configure the HTTP request pipeline.

    app.UseSwagger();
    app.UseSwaggerUI();



app.UseHttpsRedirection();

app.UseRouting();

app.UseAuthorization();

app.MapControllers();

app.Run();



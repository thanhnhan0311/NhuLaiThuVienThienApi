using Microsoft.EntityFrameworkCore;
using NhuLaiThuVienThienApi.Data;
using NhuLaiThuVienThienApi.Profiles;
using NhuLaiThuVienThienApi.Repositories;
using System.Net.NetworkInformation;
using System.Reflection;
using TechWizWebApp.Services;
using MediatR;
using System.Text.Json.Serialization;
using NhuLaiThuVienThienApi;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.ConfigureApplicationServices();

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

app.UseHttpsRedirection();

app.UseAuthorization();

app.UseCors("CorsPolicy");

app.MapControllers();

app.Run();

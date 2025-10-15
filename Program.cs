using Microsoft.EntityFrameworkCore;
using Midterm.AppDbContext;
using Midterm.DTOs;
using Midterm.Interfaces;
using Midterm.Middleware;
using Midterm.Models;
using Midterm.Services;
using System;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddScoped<IDepartmentService, DepartmentService>();
builder.Services.AddMemoryCache();
builder.Services.AddScoped<IArticleService, ArticleService>();
builder.Services.AddScoped<ICourseService, CourseService>();
builder.Services.AddScoped<IEventService, EventService>();

builder.Services.AddScoped<DbContext, CourseDbContext>();
builder.Services.AddDbContext<CourseDbContext>();

builder.Services.AddScoped<DbContext, EventDbContext>();
builder.Services.AddDbContext<EventDbContext>();

builder.Services.AddScoped<DbContext, ArticleDbContext>();
builder.Services.AddDbContext<ArticleDbContext>();

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

app.UseMiddleware<LogRequestMiddleware>();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();


using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;

var builder = WebApplication.CreateBuilder(args);
if (builder.Environment.IsProduction())
{
    Log.Logger = new LoggerConfiguration()
    .WriteTo.File("wwwroot/logs/.txt", rollingInterval: RollingInterval.Hour, outputTemplate: "[{Timestamp:yyyyMMdd HH:mm:ss.fff}][{Level:u3}] {Message:lj}{NewLine}{Exception}")
    .CreateLogger();
}
else
{
    Log.Logger = new LoggerConfiguration()
     .WriteTo.File("wwwroot\\logs\\.txt", rollingInterval: RollingInterval.Hour, outputTemplate: "[{Timestamp:yyyyMMdd HH:mm:ss.fff}][{Level:u3}] {Message:lj}{NewLine}{Exception}")
     .CreateLogger();
}

var startupConfig = builder.Configuration.GetSection("Config").Get<AppSetting>();

builder.Services.AddDbContext<RepositoryContext>(o => o.UseMySql(startupConfig.MySqlConnStr, ServerVersion.AutoDetect(startupConfig.MySqlConnStr)));

// Add services to the container.
builder.Services.AddScoped<IRepositoryBase<TblUser>, RepositoryBase<TblUser>>();
builder.Services.AddScoped<IRepositoryBase<TblUserHobby>, RepositoryBase<TblUserHobby>>();
builder.Services.AddScoped<IRepositoryBase<TblUserSkillSet>, RepositoryBase<TblUserSkillSet>>();

builder.Services.AddTransient<IUserService, UserService>();


builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAllOrigins",
        builder =>
        {
            builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader();
        });


});

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

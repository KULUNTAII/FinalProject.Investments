using FinalProject.Extensions;
using FinalProject.Middleware;
using FinalProject.Application.Extensions;
using FinalProject.Infrastructure.Extensions;
using FinalProject.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddWebApi(builder.Configuration);
builder.Services.AddApplication();
builder.Services.AddInfrastructure(builder.Configuration);

var app = builder.Build();
// Add services to the container.
app.UseMiddleware<GlobalExceptionHandling>();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseStaticFiles();

app.Use((HttpContext context, RequestDelegate next) =>
{
    return next(context);
});

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

var dbContext = app.Services.GetRequiredService<AppDbContext>();
if (dbContext.Database.GetPendingMigrations().Any())
{
    dbContext.Database.Migrate();
}
builder.Services.AddControllers();
app.Run();

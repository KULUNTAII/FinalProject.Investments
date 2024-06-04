using Microsoft.OpenApi.Models;
using System.Text.Json.Serialization;
using FinalProject.Middleware;
using FinalProject.Application.Services;
using FinalProject.Application.Services.Interfaces;

namespace FinalProject.Extensions;

public static class DependencyInjection
{
    public static IServiceCollection AddWebApi(
        this IServiceCollection services, IConfiguration configuration)
    {
        services.AddControllers().AddJsonOptions(opts =>
        {
            opts.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter());
        });

        services.AddEndpointsApiExplorer();
        services.AddSwaggerGen(c =>
        {
            c.SwaggerDoc("v1", new OpenApiInfo
            {
                Title = "SpotiPie API",
                Version = "v1"
            });

            c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
            {
                In = ParameterLocation.Header,
                Description = "Please insert JWT with Bearer into field",
                Name = "Authorization",
                Type = SecuritySchemeType.ApiKey
            });

            c.AddSecurityRequirement(
                new OpenApiSecurityRequirement()
                {
                    {
                        new OpenApiSecurityScheme()
                        {
                            Reference = new OpenApiReference()
                            {
                                Type = ReferenceType.SecurityScheme,
                                Id = "Bearer"
                            }
                        },
                        new string[] { }
                    }
                });
        });

        services.AddHttpContextAccessor();

        services.AddScoped<GlobalExceptionHandling>();

        // Сервисы

        // Регистрируем сервис пользователя и другие службы
        services.AddScoped<IAuthService, AuthService>();
        return services;
    }
}

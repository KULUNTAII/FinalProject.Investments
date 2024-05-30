using ExamProject1.Services;
using FinalProject.Application.Services;
using FinalProject.Controllers;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace FinalProject.Application.Extensions;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(
        this IServiceCollection services)
    {
        services.AddSingleton<IPasswordManager, PasswordManager>();
        services.AddTransient<IUserService, UserService>();


        services.AddScoped<IInvestorService, InvestorService>();
        services.AddScoped<IParticipantService, ParticipantService>();
        services.AddScoped<IProjectService, ProjectService>();

        services.AddAutoMapper(Assembly.GetExecutingAssembly());

        return services;
    }
}

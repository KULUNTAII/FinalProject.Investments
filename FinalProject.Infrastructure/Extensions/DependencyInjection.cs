using FinalProject.Application.Services.Interfaces.UnitOfWork;
using FinalProject.Infrastructure.Data;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using FinalProject.Infrastructure.Data.Repositories;
using Microsoft.EntityFrameworkCore;
using FinalProject.Domain.Repositories;

namespace FinalProject.Infrastructure.Extensions;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(
        this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<AppDbContext>(opts =>
            opts.UseSqlServer(configuration.GetConnectionString(nameof(AppDbContext))));

        services.AddScoped<IUnitOfWork, UnitOfWork>();

        services.AddScoped<IInvestorRepository, InvestorRepository>();
        services.AddScoped<IParticipantRepository, ParticipantRepository>();
        services.AddScoped<IProjectRepository, ProjectRepository>();

        services.AddScoped<IUserRepository, UserRepository>();
        services.AddScoped<IAuthRepository, AuthRepository>();
        return services;
    }
}

using FinalProject.Application.Services.Interfaces.UnitOfWork;
using FinalProject.Infrastructure.Data;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using FinalProject.Infrastructure.Data.Repositories;
using Microsoft.EntityFrameworkCore;
using FinalProject.Domain.Repositories;
using System;
using FinalProject.Application.Services;

namespace FinalProject.Application.Extensions;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(
        this IServiceCollection services, IConfiguration configuration)
    {

        services.AddScoped<IInvestorService, InvestorService>();
        services.AddScoped<IParticipantService, ParticipantService>();
        services.AddScoped<IProjectService, ProjectService>();

        return services;
    }
}

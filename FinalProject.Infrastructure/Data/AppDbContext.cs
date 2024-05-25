using FinalProject.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;

public class AppDbContext(DbContextOptions<AppDbContext> opts) : DbContext(opts)
{
    public DbSet<Investor> Investors => Set<Investor>();
    public DbSet<Project> Projects => Set<Project>();
    public DbSet<Participant> Participants => Set<Participant>();
    public DbSet<QualificationType> QualificationTypes => Set<QualificationType>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }
}

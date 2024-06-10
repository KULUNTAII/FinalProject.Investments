using FinalProject.Domain.Entities;
using Microsoft.EntityFrameworkCore;

public class AppDbContext(DbContextOptions<AppDbContext> opts) : DbContext(opts)
{
    public DbSet<Investor> Investors => Set<Investor>();
    public DbSet<Project> Projects => Set<Project>();
    public DbSet<Participant> Participants => Set<Participant>();
    public DbSet<QualificationType> QualificationTypes => Set<QualificationType>();
    public DbSet<User> Users => Set<User>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Investor>().Property(i => i.Id).ValueGeneratedNever();
        modelBuilder.Entity<Participant>().Property(p => p.Id).ValueGeneratedNever();
         
        modelBuilder.Entity<User>()
            .HasOne(u => u.Investor)
            .WithOne()
            .HasForeignKey<Investor>(i => i.Id);

        modelBuilder.Entity<User>()
            .HasOne(u => u.Participant)
            .WithOne()
            .HasForeignKey<Participant>(p => p.Id);

        modelBuilder.Entity<User>()
            .Navigation(u => u.Investor)
            .AutoInclude();

        modelBuilder.Entity<User>()
            .Navigation(u => u.Participant)
            .AutoInclude();
    }
}

using CleanArchitecture.Domain.Model;
using Microsoft.EntityFrameworkCore;

namespace CleanArchitecture.Domain.Shared;

public interface IApplicationDBContext
{
    public DbSet<Author> Authors { get; set; }
    public DbSet<Companion> Companions { get; set; }
    public DbSet<Doctor> Doctors { get; set; }
    public DbSet<Episode> Episodes { get; set; }
    public DbSet<Enemy> Enemies { get; set; }
    public DbSet<EpisodeCompanion> EpisodeCompanions { get; set; }
    public DbSet<EpisodeEnemy> EpisodeEnemies { get; set; }

    Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
}
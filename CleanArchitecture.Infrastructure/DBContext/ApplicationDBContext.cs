using CleanArchitecture.Domain.Model;
using CleanArchitecture.Domain.Shared;
using Microsoft.EntityFrameworkCore;

namespace CleanArchitecture.Infrastructure.DBContext;

public class ApplicationDBContext : DbContext, IApplicationDBContext
{
    public ApplicationDBContext(DbContextOptions options):base(options) {}
    
    public DbSet<Author> Authors { get; set; }
    public DbSet<Companion> Companions { get; set; }
    public DbSet<Doctor> Doctors { get; set; }
    public DbSet<Episode> Episodes { get; set; }
    public DbSet<Enemy> Enemies { get; set; }
    public DbSet<EpisodeCompanion> EpisodeCompanions { get; set; }
    public DbSet<EpisodeEnemy> EpisodeEnemies { get; set; }
}
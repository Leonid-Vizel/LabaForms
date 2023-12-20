using LabaForms.Models;
using LabaForms.Queries;
using Microsoft.EntityFrameworkCore;

namespace LabaForms.Data;

public sealed class ApplicationDbContext : DbContext
{
    public DbSet<Material> Materials { get; set; }
    public DbSet<Norm> Norms { get; set; }
    public DbSet<Operation> Operations { get; set; }
    public DbSet<Part> Parts { get; set; }
    public DbSet<Profession> Professions { get; set; }
    public DbSet<Tarif> Tarifs { get; set; }
    public DbSet<Query1Result> Query1 { get; set; } = null!;
    public DbSet<Query2Result> Query2 { get; set; } = null!;
    public DbSet<Query3Result> Query3 { get; set; } = null!;

    private readonly string _host = "localhost";
    private readonly string _port = "5432";
    private readonly string _username = "postgres";
    private readonly string _password = "admin";
    private readonly string _dbName = "dbTesting";
    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        options.UseNpgsql($"Host={_host};Port={_port};Username={_username};Password={_password};Database={_dbName};Timeout=1024;CommandTimeout=1024;ConnectionIdleLifetime=20;", npgsql =>
        {
            npgsql.UseQuerySplittingBehavior(QuerySplittingBehavior.SplitQuery);
        });
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.Entity<Query1Result>()
            .HasNoKey()
            .ToView(null);

        builder.Entity<Query2Result>()
            .HasNoKey()
            .ToView(null);

        builder.Entity<Query3Result>()
            .HasNoKey()
            .ToView(null);
    }
}

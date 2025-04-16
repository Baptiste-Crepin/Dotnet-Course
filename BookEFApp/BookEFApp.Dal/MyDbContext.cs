using BookEFApp.Models;
using Microsoft.EntityFrameworkCore;

namespace BookEFApp.Dal;

public class MyDbContext : DbContext, IDalBookStore
{
    public MyDbContext()
    {
    }

    public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
    {
    }

    public DbSet<Auteur> Auteurs { get; set; }
    public DbSet<Livre> Livres { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseNpgsql(
                "Host=localhost;Port=5432;Password=MyStrongPassword123;Persist Security Info=True;Username=bcrepin;Database=Course");
        }
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Auteur>().ToTable("Auteurs");
        modelBuilder.Entity<Livre>().ToTable("Livres");

        modelBuilder.Entity<Auteur>().HasData(
            new Auteur
            {
                Id = 1,
                Nom = "Jean-Claude",
                DateNaissance = new DateOnly(1980, 12, 31)
            },
            new Auteur
            {
                Id = 2,
                Nom = "Jean-Claude",
                DateNaissance = new DateOnly(1990, 12, 31)
            },
            new Auteur
            {
                Id = 3,
                Nom = "Jean-Claude",
                DateNaissance = new DateOnly(2000, 12, 31)
            }
        );

        modelBuilder.Entity<Livre>().HasData(
            new Livre
            {
                Id = 1,
                Titre = "Le livre 1",
                Date = new DateOnly(2020, 12, 31),
                AuteurId = 1
            },
            new Livre
            {
                Id = 2,
                Titre = "Le livre 2",
                Date = new DateOnly(2021, 12, 31),
                AuteurId = 2
            },
            new Livre
            {
                Id = 3,
                Titre = "Le livre 3",
                Date = new DateOnly(2022, 12, 31),
                AuteurId = 3
            },
            new Livre
            {
                Id = 4,
                Titre = "Le livre 4",
                Date = new DateOnly(2023, 12, 31),
                AuteurId = 3
            }
        );

        base.OnModelCreating(modelBuilder);
    }

    public List<Auteur> GetAuteurs()
    {
        return base
            .Set<Auteur>()
            .Include(a => a.Livres)
            .ToList();
    }
}
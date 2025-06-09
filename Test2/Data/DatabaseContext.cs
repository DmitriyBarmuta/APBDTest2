using Microsoft.EntityFrameworkCore;
using Test2.Models;

namespace Test2.Data;

public class DatabaseContext : DbContext
{
    public DbSet<Race> Races { get; set; }
    public DbSet<Racer> Racers { get; set; }
    public DbSet<Track> Tracks { get; set; }
    public DbSet<TrackRace> TrackRaces { get; set; }
    public DbSet<RaceParticipation> RaceParticipations { get; set; }
    
    protected DatabaseContext()
    {
    }

    public DatabaseContext(DbContextOptions options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<RaceParticipation>().HasKey(rp => new { rp.TrackRaceId, rp.RacerId });
        
        modelBuilder.Entity<Race>().HasData(
            new Race { RaceId = 1, Name = "Circle Race", Location = "Italia", Date = new DateTime(2025, 6, 10, 0, 0, 0, DateTimeKind.Local) },
            new Race { RaceId = 2, Name = "Lap in forest", Location = "Georgia", Date = new DateTime(2025, 6, 18, 0, 0, 0, DateTimeKind.Local) },
            new Race { RaceId = 3, Name = "Rally go", Location = "USA", Date = new DateTime(2025, 6, 12, 0, 0, 0, DateTimeKind.Local) }
        );
        modelBuilder.Entity<Track>().HasData(
            new Track { TrackId = 1, Name = "Sprint", LengthInKm = 120},
            new Track { TrackId = 2, Name = "Drift", LengthInKm = 250},
            new Track { TrackId = 3, Name = "Rally", LengthInKm = 340}
        );

        modelBuilder.Entity<Racer>().HasData(
            new Racer { RacerId = 1, FirstName = "Dmitriy", LastName = "Barmuta" },
            new Racer { RacerId = 2, FirstName = "Michal", LastName = "Pazio" },
            new Racer { RacerId = 3, FirstName = "Daniil", LastName = "Danillian" }
        );

        modelBuilder.Entity<TrackRace>().HasData(
            new TrackRace { TrackRaceId = 1, TrackId = 1, RaceId = 1, Laps = 2, BestTimeInSeconds = 605},
            new TrackRace { TrackRaceId = 2, TrackId = 1, RaceId = 2, Laps = 1, BestTimeInSeconds = 322},
            new TrackRace { TrackRaceId = 3, TrackId = 2, RaceId = 3, Laps = 5, BestTimeInSeconds = 1432}
        );

        modelBuilder.Entity<RaceParticipation>().HasData(
            new RaceParticipation { TrackRaceId = 1, RacerId = 1, FinishTimeInSeconds = 605, Position = 1},
            new RaceParticipation { TrackRaceId = 2, RacerId = 2, FinishTimeInSeconds = 889, Position = 4},
            new RaceParticipation { TrackRaceId = 3, RacerId = 3, FinishTimeInSeconds = 1400, Position = 2}
        );
    }
}
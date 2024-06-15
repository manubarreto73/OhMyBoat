namespace OMB.Repositories;

using Microsoft.EntityFrameworkCore;
using OMB.Aplication.ClasesBase;

public class OMBContext : DbContext{
    
    #nullable disable

    public DbSet<User> Users {get; set;}

    public DbSet<Employee> Employees {get; set;}

    public DbSet<Ship> Ships {get; set;}

    public DbSet<Transport> Transports {get; set;}

    public DbSet<Vehicle> Vehicles {get; set;}

    public DbSet<Post> Posts {get; set;}

    public DbSet<ShipImage> ShipImages {get; set;}
    
    public DbSet<VehicleImage> VehicleImages {get; set;}
    public DbSet<Offer> Offers {get; set;}
    public DbSet<VehicleHistory> VehiclesHistory {get; set;}
    public DbSet<ShipHistory> ShipsHistory {get; set;}
    public DbSet<ResolvedExchange> ResolvedExchanges {get; set;}
    public DbSet<UnresolvedExchange> UnresolvedExchanges {get; set;}
    public DbSet<Sede> Sedes { get; set; }

    #nullable restore

   protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Configure TPT for the inheritance hierarchy
        modelBuilder.Entity<Transport>()
            .ToTable("Transports")
            .HasKey(t => t.Id);

        modelBuilder.Entity<Vehicle>()
            .ToTable("Vehicles")
            .HasBaseType<Transport>();

        modelBuilder.Entity<Ship>()
            .ToTable("Ships")
            .HasBaseType<Transport>();

        // Configure User entity
        modelBuilder.Entity<User>()
            .ToTable("Users")
            .HasKey(u => u.Id);

        // Configure the relationship between Ship and User
        modelBuilder.Entity<Transport>()
            .HasOne(s => s.owner)
            .WithMany(u => u.Transports)
            .HasForeignKey(s => s.UserId); // Ensure it's not nullable

        modelBuilder.Entity<VehicleHistory>()
            .ToTable("VehiclesHistory")
            .HasBaseType<TransportHistory>();

        modelBuilder.Entity<ShipHistory>()
            .ToTable("ShipsHistory")
            .HasBaseType<TransportHistory>();

        base.OnModelCreating(modelBuilder);

    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
        optionsBuilder.UseSqlite("data source=OMB.Repositories.sqlite");
    }
    //No estoy segura de que esta configuración funcione, recemos.

}
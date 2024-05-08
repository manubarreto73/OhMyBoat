namespace OMB.Repositories;

using Microsoft.EntityFrameworkCore;
using OMB.Aplication.ClasesBase;

public class OMBContext : DbContext{
    
    #nullable disable

    public DbSet<User> Users {get; set;}
    public DbSet<Employee> Employees {get; set;}

    public DbSet<Ship> Ships {get; set;}

    public DbSet<Vehicle> Vehicles {get; set;}

    public DbSet<VehiclePost> VehiclePosts {get; set;}

    public DbSet<ShipPost> ShipPosts {get; set;}

    public DbSet<ShipImage> ShipImages {get; set;}
    
    public DbSet<VehicleImage> VehicleImages {get; set;}

    #nullable restore

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
        optionsBuilder.UseSqlite("data source=OMB.Repositories.sqlite");
    }
    //No estoy segura de que esta configuración funcione, recemos.

}
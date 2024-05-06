using OMB.Repositories;
using OMB.Aplication.ClasesBase;

namespace OMB.UI;

public class Testing{

    public static void Initialize(OMBContext context){
        DateOnly birthDate = DateOnly.FromDateTime(DateTime.Today.AddYears(-21));
        if(context.Users.Count() == 0){
            context.Add(new User("Manu", "Barreto", "manubarreto", "manuel123", "manubarreto@gmail.com", "221123123", birthDate)); //1
            context.Add(new User("Luis", "González", "luisgonzalez", "luiss123", "luisgonzalez@gmail.com", "221456456", birthDate)); //2
            context.Add(new User("María", "Rodríguez", "mariarodriguez", "maria123", "mariarodriguez@gmail.com", "221789789", birthDate)); //3
            context.Add(new User("Pedro", "Martínez", "pedromartinez", "pedro123", "pedromartinez@gmail.com", "221987654", birthDate)); //4
            context.Add(new User("Ana", "Sánchez", "anasanchez", "anasan123", "anasanchez@gmail.com", "221654321", birthDate)); //5
            context.Add(new User("Lucía", "Fernández", "luciafernandez", "lucia123", "luciafernandez@gmail.com", "221111222", birthDate)); //6
            context.Add(new User("Javier", "Díaz", "javierdiaz", "javier123", "javierdiaz@gmail.com", "221333444", birthDate)); //7
            context.Add(new User("Laura", "López", "lauralopez", "laura123", "lauralopez@gmail.com", "221555666", birthDate)); //8
        }
        context.SaveChanges();
        if(context.Vehicles.Count() == 0){
            context.Add(new Vehicle(3, "Auto", "ABC123", "En buen estado", "Fiat", 90000, 3));
            context.Add(new Vehicle(5, "Moto", "DEF456", "Pocos kms", "Honda", 5000, 0));
            context.Add(new Vehicle(2, "Camioneta", "GHI789", "Excelente estado", "Toyota", 110000, 5));
            context.Add(new Vehicle(5, "Auto", "JKL012", "Usado", "Ford", 80000, 5));
            context.Add(new Vehicle(5, "Moto", "MNO345", "Detalles estéticos", "Yamaha", 25000, 0));
            context.Add(new Vehicle(3, "Camioneta", "PQR678", "Funciona correctamente", "Chevrolet", 95000, 5));
            context.Add(new Vehicle(6, "Auto", "STU901", "Para reparar", "Volkswagen", 120000, 3));
            context.Add(new Vehicle(4, "Camioneta", "VWX234", "Gran capacidad de carga", "Nissan", 70000, 5));
        }
        context.SaveChanges();
        if(context.Ships.Count() == 0){
            context.Add(new Ship(2, "Catamaran", "ABC123", "Ta lindo", 15, 20, 25, true));
            context.Add(new Ship(3, "Lancha", "ABC124", "No ta lindo", 10, 15, 20, false));
            context.Add(new Ship(4, "Catamaran", "ABC125", "Ta medio feo", 20, 25, 30, true));
            context.Add(new Ship(5, "Lancha", "ABC126", "Ta roto", 5, 10, 15, false));
            context.Add(new Ship(2, "Catamaran", "ABC127", "No, ayuda, de vrd", 2, 3, 4, true));
            context.Add(new Ship(3, "Lancha", "ABC128", "Necesita reparación", 4, 3, 2, false));
            context.Add(new Ship(4, "Catamaran", "ABC129", "X q hago yo este trabajo", 1, 2, 3, true));
            context.Add(new Ship(5, "Lacha", "ABC139", "Es aburrido", 7, 6, 23, false));
        }
        context.SaveChanges();
        if(context.VehiclePosts.Count() == 0){
            context.Add(new VehiclePost(2));
            context.Add(new VehiclePost(3));
            context.Add(new VehiclePost(4));
            context.Add(new VehiclePost(5));
            context.Add(new VehiclePost(6));
            context.Add(new VehiclePost(7));
            context.Add(new VehiclePost(8));
        }
        context.SaveChanges();
        if(context.ShipPosts.Count() == 0){
            context.Add(new ShipPost(2));
            context.Add(new ShipPost(3));
            context.Add(new ShipPost(4));
            context.Add(new ShipPost(5));
            context.Add(new ShipPost(6));
            context.Add(new ShipPost(7));
            context.Add(new ShipPost(8));
        }
        context.SaveChanges();
    }

}
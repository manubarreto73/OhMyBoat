using OMB.Repositories;
using OMB.Aplication.ClasesBase;

namespace OMB.UI;

public class Testing{

    public static void Initialize(OMBContext context){
        DateOnly birthDate = DateOnly.FromDateTime(DateTime.Today.AddYears(-21));
        if(context.Users.Count() == 0){
            context.Add(new User("Manu", "Barreto", "manubarreto", "manu123", "manubarreto@gmail.com", "221123123", birthDate)); //1
            context.Add(new User("Luis", "González", "luisgonzalez", "luis123", "luisgonzalez@gmail.com", "221456456", birthDate)); //2
            context.Add(new User("María", "Rodríguez", "mariarodriguez", "maria123", "mariarodriguez@gmail.com", "221789789", birthDate)); //3
            context.Add(new User("Pedro", "Martínez", "pedromartinez", "pedro123", "pedromartinez@gmail.com", "221987654", birthDate)); //4
            context.Add(new User("Ana", "Sánchez", "anasanchez", "ana123", "anasanchez@gmail.com", "221654321", birthDate)); //5
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
        //Esto produce un error de 'FOREIGN KEY constraint failed', no sé por qué
        if(context.Ships.Count() == 0){
            
        }
        context.SaveChanges();
        if(context.VehiclePosts.Count() == 0){
            
        }
        context.SaveChanges();
        if(context.ShipPosts.Count() == 0){
            
        }
        context.SaveChanges();
    }

}
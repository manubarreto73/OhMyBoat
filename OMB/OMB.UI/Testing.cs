using OMB.Repositories;
using OMB.Aplication.ClasesBase;
using System.Drawing;

namespace OMB.UI;

public class Testing{

    public static void Initialize(){
        DateOnly birthDate = DateOnly.FromDateTime(DateTime.Today.AddYears(-21));
        using(OMBContext context = new OMBContext()){
        if(context.Users.Count() == 0){
            context.Users.Add(new User("Manu", "Barreto", "manubarreto", "manuel123", "manubarreto@gmail.com", "221123123", birthDate)); //1
            context.Users.Add(new User("Luis", "González", "luisgonzalez", "luiss123", "luisgonzalez@gmail.com", "221456456", birthDate)); //2
            context.Users.Add(new User("María", "Rodríguez", "mariarodriguez", "maria123", "mariarodriguez@gmail.com", "221789789", birthDate)); //3
            context.Users.Add(new User("Pedro", "Martínez", "pedromartinez", "pedro123", "pedromartinez@gmail.com", "221987654", birthDate)); //4
            context.Users.Add(new User("Ana", "Sánchez", "anasanchez", "anasan123", "anasanchez@gmail.com", "221654321", birthDate)); //5
            context.Users.Add(new User("Lucía", "Fernández", "luciafernandez", "lucia123", "luciafernandez@gmail.com", "221111222", birthDate)); //6
            context.Users.Add(new User("Javier", "Díaz", "javierdiaz", "javier123", "javierdiaz@gmail.com", "221333444", birthDate)); //7
            context.Users.Add(new User("Laura", "López", "lauralopez", "laura123", "lauralopez@gmail.com", "221555666", birthDate)); //8
        }
        context.SaveChanges();
        }
        using(OMBContext context = new OMBContext()){
        if(context.Employees.Count() == 0){
            context.Employees.Add(new Employee("Daniel", "Perez", "DanielP", "PaseAdmin", "daniel@gmail.com", "221512748", birthDate)); //1 ADMIN
            context.Employees.Add(new Employee("Tadeo", "Etcheverría", "tadeoetche", "tadeo123", "tadeo@gmail.com", "221512465", birthDate)); //2
            context.Employees.Add(new Employee("Renata", "Vargas", "renatavargas", "renata123", "renatavargas@gmail.com", "221777888", birthDate)); //3
            context.Employees.Add(new Employee("Matías", "Fernández", "matiasfernandez", "matias123", "matiasfernandez@gmail.com", "221999000", birthDate)); //4
        }
        context.SaveChanges();
        }

        using(OMBContext context = new OMBContext()){
        if(context.Vehicles.Count() == 0){
            context.Add(new Vehicle(3, "Auto", "ABC123", "En buen estado", "Fiat Pulse", 90000, 3));
            context.Add(new Vehicle(5, "Ciclomotor", "DEF456", "Pocos kms", "Honda Accord Hybrid", 5000, 0));
            context.Add(new Vehicle(2, "Camioneta", "GHI789", "Excelente estado", "GR Yaris", 110000, 5));
            context.Add(new Vehicle(1, "Auto", "JKL012", "Con cambio automático", "Ford Kuga Hibrida", 80000, 5));
            context.Add(new Vehicle(5, "Ciclomotor", "MNO345", "A prueba de granizo y golpes leves", "Yamaha XTZ 250", 25000, 0));
            context.Add(new Vehicle(3, "Camioneta", "PQR678", "Buen motor, funciona con cualquier combustible", "Cruze RS", 95000, 5));
            context.Add(new Vehicle(6, "Auto", "STU901", "Eléctrico, nuevo", "Nueva Saveiro", 120000, 3));
            context.Add(new Vehicle(4, "Auto", "VWX234", "Gran capacidad de carga", "Nissan Versa", 70000, 5));
            context.SaveChanges();
        }
        
        if(context.Ships.Count() == 0){
            context.Add(new Ship(2, "Crucero", "ABC123", "Capacidad maxima de 150 personas", "Antares 9 OB", 15, 20, 25, true));
            context.Add(new Ship(3, "Velero", "DBE030", "Muy veloz", "Oceanis 461", 10, 15, 20, false));
            context.Add(new Ship(4, "Catamaran", "XFK535", "Apto para aguas agitadas, buena cobertura", "First 40.7", 20, 25, 30, true));
            context.Add(new Ship(5, "Lancha", "LKM792", "Modelo clásico y resistente, buena capacidad de carga", "242 GTO", 5, 10, 15, false));
            context.Add(new Ship(2, "Crucero", "RTS222", "Es un modelo muy seguro, y muy fácil de conducir, ideal para principiantes", "188 JOY", 2, 3, 4, true));
            context.Add(new Ship(3, "Velero", "VYW323", "Espacio para dos personas, muy cómodo y muy rápido", "Cranchi Endurance 33", 4, 3, 2, false));
            context.Add(new Ship(4, "Catamaran", "POR175", "En buenas condiciones, motor de alta potencia con poco consumo de combustible", "Marinello Eden 18", 1, 2, 3, true));
            context.Add(new Ship(5, "Lacha", "QFT459", "Practicamente nuevo, ideal para salidas veraniegas", "Flyer 9 SUNdeck", 7, 6, 23, false));
            context.SaveChanges();
        }
        }
        
        using(OMBContext context = new OMBContext()){
        if(context.VehiclePosts.Count() == 0){
            
            context.Add(new VehiclePost(2, "Moto Honda sin uso"));
            context.Add(new VehiclePost(3, "Toyota reluciente"));
            context.Add(new VehiclePost(4, "Auto familiar para viajar con la familia"));
            context.Add(new VehiclePost(5, "Resistente moto de largas distancias"));
            context.Add(new VehiclePost(6, "Camioneta 4x4 todoterreno"));
            context.Add(new VehiclePost(7, "A energía eléctrica, y con buenas luces"));
        }
        if(context.ShipPosts.Count() == 0){
            context.Add(new ShipPost(2, "Oceanis 461 de altas velocidades"));
            context.Add(new ShipPost(3, "Catamaran muy seguro"));
            context.Add(new ShipPost(4, "Clasica lancha 242 GTO"));
            context.Add(new ShipPost(5, "Espacioso crucero, seguridad asegurada"));
            context.Add(new ShipPost(6, "Velero Cranchi por moto"));
            context.Add(new ShipPost(7, "Catamaran casi nuevo"));
        }
        context.SaveChanges();
        }
        #pragma warning disable CA1416 // Sirve para que desaparezcan warnings
        using(OMBContext context = new OMBContext()){
            if(context.ShipImages.Count() == 0){
                Image? img;
                using(var ms = new MemoryStream()){
                    img = Image.FromFile("Velero 1.jpg");
                    img.Save(ms, img.RawFormat);
                    context.Add(new ShipImage(2, ms.ToArray()));
                }
                using(var ms = new MemoryStream()){
                    img = Image.FromFile("Catamaran 1.jpg");
                    img.Save(ms, img.RawFormat);
                    context.Add(new ShipImage(3, ms.ToArray()));
                }
                using(var ms = new MemoryStream()){
                    img = Image.FromFile("Lancha.jpg");
                    img.Save(ms, img.RawFormat);
                    context.Add(new ShipImage(4, ms.ToArray()));
                }
                using(var ms = new MemoryStream()){
                    img = Image.FromFile("Crucero 1.jpg");
                    img.Save(ms, img.RawFormat);
                    context.Add(new ShipImage(5, ms.ToArray()));
                }
                using(var ms = new MemoryStream()){
                    img = Image.FromFile("Velero 2.png");
                    img.Save(ms, img.RawFormat);
                    context.Add(new ShipImage(6, ms.ToArray()));
                }
                using(var ms = new MemoryStream()){
                    img = Image.FromFile("Catamaran 2.jpg");
                    img.Save(ms, img.RawFormat);
                    context.Add(new ShipImage(7, ms.ToArray()));
                }
                using(var ms = new MemoryStream()){
                    img = Image.FromFile("Crucero 2.jpg");
                    img.Save(ms, img.RawFormat);
                    context.Add(new ShipImage(1, ms.ToArray()));
                }
                using(var ms = new MemoryStream()){
                    img = Image.FromFile("Lancha 2.jpg");
                    img.Save(ms, img.RawFormat);
                    context.Add(new ShipImage(8, ms.ToArray()));
                }
                context.SaveChanges();
            }
            if(context.VehicleImages.Count() == 0){
                Image? img;
                using(var ms = new MemoryStream()){
                    img = Image.FromFile("Honda.jpg");
                    img.Save(ms, img.RawFormat);
                    context.Add(new VehicleImage(2, ms.ToArray()));
                }
                using(var ms = new MemoryStream()){
                    img = Image.FromFile("GR Yaris.jpg");
                    img.Save(ms, img.RawFormat);
                    context.Add(new VehicleImage(3, ms.ToArray()));
                }
                using(var ms = new MemoryStream()){
                    img = Image.FromFile("Ford Kuga.jpg");
                    img.Save(ms, img.RawFormat);
                    context.Add(new VehicleImage(4, ms.ToArray()));
                }
                using(var ms = new MemoryStream()){
                    img = Image.FromFile("Yamaha.jpg");
                    img.Save(ms, img.RawFormat);
                    context.Add(new VehicleImage(5, ms.ToArray()));
                }
                using(var ms = new MemoryStream()){
                    img = Image.FromFile("Cruze RS.jpg");
                    img.Save(ms, img.RawFormat);
                    context.Add(new VehicleImage(6, ms.ToArray()));
                }
                using(var ms = new MemoryStream()){
                    img = Image.FromFile("Nueva Saveiro.jpg");
                    img.Save(ms, img.RawFormat);
                    context.Add(new VehicleImage(7, ms.ToArray()));
                }
                using(var ms = new MemoryStream()){
                    img = Image.FromFile("Fiat Pulse.jpg");
                    img.Save(ms, img.RawFormat);
                    context.Add(new VehicleImage(1, ms.ToArray()));
                }
                using(var ms = new MemoryStream()){
                    img = Image.FromFile("Nissan Versa 1.jpg");
                    img.Save(ms, img.RawFormat);
                    context.Add(new VehicleImage(8, ms.ToArray()));
                }
                using(var ms = new MemoryStream()){
                    img = Image.FromFile("Nissan Versa 2.jpg");
                    img.Save(ms, img.RawFormat);
                    context.Add(new VehicleImage(8, ms.ToArray()));
                }
                using(var ms = new MemoryStream()){
                    img = Image.FromFile("Nissan Versa 3.jpeg");
                    img.Save(ms, img.RawFormat);
                    context.Add(new VehicleImage(8, ms.ToArray()));
                }
                context.SaveChanges();
            }
        }
        #pragma warning restore CA1416
    }

}
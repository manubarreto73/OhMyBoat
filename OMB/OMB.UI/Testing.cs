using OMB.Repositories;
using OMB.Aplication.ClasesBase;
using System.Drawing;

namespace OMB.UI;

public class Testing{

    public static void Initialize(){
        using(OMBContext context = new OMBContext()){
        if(context.Sedes.Count() == 0) {
            context.Sedes.Add(new Sede("La plata", -34.83293595689235, -57.8829434918476));
            context.Sedes.Add(new Sede("Berisso", -34.82872143387457, -57.95478334351441));
            context.Sedes.Add(new Sede("CABA", -34.85655905691365, -57.83745271400811));
        }
        context.SaveChanges();
        }
        DateOnly birthDate = DateOnly.FromDateTime(DateTime.Today.AddYears(-21));
        using(OMBContext context = new OMBContext()){
        if(context.Users.Count() == 0){
            context.Users.Add(new User("-", "-", "Usuario No Disponible", "-", "auxiliar@gmail.com", "221123123", birthDate)); //1
            context.Users.Add(new User("Manu", "Barreto", "manubarreto", "manuel123", "manuel@gmail.com", "221123123", birthDate)); //2
            /*context.Users.Add(new User("Luis", "González", "luisgonzalez", "luiss123", "luisgonzalez@gmail.com", "221456456", birthDate)); //3
            context.Users.Add(new User("María", "Rodríguez", "mariarodriguez", "maria123", "mariarodriguez@gmail.com", "221789789", birthDate)); //4
            context.Users.Add(new User("Pedro", "Martínez", "pedromartinez", "pedro123", "pedromartinez@gmail.com", "221987654", birthDate)); //5
            context.Users.Add(new User("Ana", "Sánchez", "anasanchez", "anasan123", "anasanchez@gmail.com", "221654321", birthDate)); //6
            context.Users.Add(new User("Lucía", "Fernández", "luciafernandez", "lucia123", "luciafernandez@gmail.com", "221111222", birthDate));*/ //7
            context.Users.Add(new User("Joaquín", "Malchansky", "joaco", "123123123", "joaquin@gmail.com", "221333444", birthDate)); //8
            //context.Users.Add(new User("Ivy", "Daguerre", "ivy", "123123123", "elmaildeivy@gmail.com", "221555666", birthDate)); //9
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
            context.Add(new Vehicle(1, "-", "-", "-", "Lo lamentamos, este vehiculo fue eliminado", 0, 0));
            context.Add(new Vehicle(2, "Auto", "ABC123", "En buen estado", "Fiat Pulse", 90000, 3));
            context.Add(new Vehicle(3, "Ciclomotor", "DEF456", "Pocos kms", "Honda Accord Hybrid", 5000, 0));
            context.Add(new Vehicle(2, "Camioneta", "GHI789", "Excelente estado", "GR Yaris", 110000, 5));
            context.Add(new Vehicle(2, "Auto", "JKL012", "Con cambio automático", "Ford Kuga Hibrida", 80000, 5));
            context.Add(new Vehicle(2, "Ciclomotor", "MNO345", "A prueba de granizo y golpes leves", "Yamaha XTZ 250", 25000, 0));
            context.Add(new Vehicle(2, "Camioneta", "PQR678", "Buen motor, funciona con cualquier combustible", "Cruze RS", 95000, 5));
            context.Add(new Vehicle(3, "Auto", "STU901", "Eléctrico, nuevo", "Nueva Saveiro", 120000, 3));
            context.Add(new Vehicle(3, "Auto", "VWX234", "Gran capacidad de carga", "Nissan Versa", 70000, 5));
            context.SaveChanges();
        }
        
        if(context.Ships.Count() == 0){
            context.Add(new Ship(1, "-", "-", "-", "Lo lamentamos, este vehiculo fue eliminado", 0, 0, 0, true));
            context.Add(new Ship(2, "Crucero", "ABC123", "Capacidad maxima de 150 personas", "Antares 9 OB", 15, 20, 25, true));
            context.Add(new Ship(2, "Velero", "DBE030", "Muy veloz", "Oceanis 461", 10, 15, 20, false));
            context.Add(new Ship(2, "Catamaran", "XFK535", "Apto para aguas agitadas, buena cobertura", "First 40.7", 20, 25, 30, true));
            context.Add(new Ship(2, "Lancha", "LKM792", "Modelo clásico y resistente, buena capacidad de carga", "242 GTO", 5, 10, 15, false));
            context.Add(new Ship(2, "Crucero", "RTS222", "Es un modelo muy seguro, y muy fácil de conducir, ideal para principiantes", "188 JOY", 2, 3, 4, true));
            context.Add(new Ship(2, "Velero", "VYW323", "Espacio para dos personas, muy cómodo y muy rápido", "Cranchi Endurance 33", 4, 3, 2, false));
            context.Add(new Ship(3, "Catamaran", "POR175", "En buenas condiciones, motor de alta potencia con poco consumo de combustible", "Marinello Eden 18", 1, 2, 3, true));
            context.Add(new Ship(3, "Lancha", "QFT459", "Practicamente nuevo, ideal para salidas veraniegas", "Flyer 9 SUNdeck", 7, 6, 23, false));
            context.SaveChanges();
        }
        }
        
        using(OMBContext context = new OMBContext()){
        if(context.Posts.Count() == 0){
            context.Add(new Post(1, "Publicación no disponible, lo lamentamos"){paused = true});
            context.Add(new Post(10, "Publicación no disponible, lo lamentamos"){paused = true});
            context.Add(new Post(3, "Moto Honda sin uso"));
            context.Add(new Post(4, "Toyota reluciente"));
            context.Add(new Post(5, "Auto familiar para viajar con la familia"));
            context.Add(new Post(6, "Resistente moto de largas distancias"));
            context.Add(new Post(7, "Camioneta 4x4 todoterreno"){paused=true});
            context.Add(new Post(8, "A energía eléctrica, y con buenas luces"){paused=true});
            context.Add(new Post(12, "Oceanis 461 de altas velocidades"){paused=true});
            context.Add(new Post(13, "Catamaran muy seguro"));
            context.Add(new Post(14, "Clasica lancha 242 GTO"));
            context.Add(new Post(15, "Espacioso crucero, seguridad asegurada"));
            context.Add(new Post(16, "Velero Cranchi por moto"));
            context.Add(new Post(17, "Catamaran casi nuevo"));
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
                    context.Add(new ShipImage(12, ms.ToArray()));
                }
                using(var ms = new MemoryStream()){
                    img = Image.FromFile("Catamaran 1.jpg");
                    img.Save(ms, img.RawFormat);
                    context.Add(new ShipImage(13, ms.ToArray()));
                }
                using(var ms = new MemoryStream()){
                    img = Image.FromFile("Lancha.jpg");
                    img.Save(ms, img.RawFormat);
                    context.Add(new ShipImage(14, ms.ToArray()));
                }
                using(var ms = new MemoryStream()){
                    img = Image.FromFile("Crucero 1.jpg");
                    img.Save(ms, img.RawFormat);
                    context.Add(new ShipImage(15, ms.ToArray()));
                }
                using(var ms = new MemoryStream()){
                    img = Image.FromFile("Velero 2.png");
                    img.Save(ms, img.RawFormat);
                    context.Add(new ShipImage(16, ms.ToArray()));
                }
                using(var ms = new MemoryStream()){
                    img = Image.FromFile("Catamaran 2.jpg");
                    img.Save(ms, img.RawFormat);
                    context.Add(new ShipImage(17, ms.ToArray()));
                }
                using(var ms = new MemoryStream()){
                    img = Image.FromFile("Crucero 2.jpg");
                    img.Save(ms, img.RawFormat);
                    context.Add(new ShipImage(11, ms.ToArray()));
                }
                using(var ms = new MemoryStream()){
                    img = Image.FromFile("Lancha 2.jpg");
                    img.Save(ms, img.RawFormat);
                    context.Add(new ShipImage(18, ms.ToArray()));
                }
                using(var ms = new MemoryStream()){
                    img = Image.FromFile("404.jpg");
                    img.Save(ms, img.RawFormat);
                    context.Add(new ShipImage(10, ms.ToArray()));
                }
                context.SaveChanges();
            }
            if(context.VehicleImages.Count() == 0){
                Image? img;
                using(var ms = new MemoryStream()){
                    img = Image.FromFile("Honda.jpg");
                    img.Save(ms, img.RawFormat);
                    context.Add(new VehicleImage(3, ms.ToArray()));
                }
                using(var ms = new MemoryStream()){
                    img = Image.FromFile("GR Yaris.jpg");
                    img.Save(ms, img.RawFormat);
                    context.Add(new VehicleImage(4, ms.ToArray()));
                }
                using(var ms = new MemoryStream()){
                    img = Image.FromFile("Ford Kuga.jpg");
                    img.Save(ms, img.RawFormat);
                    context.Add(new VehicleImage(5, ms.ToArray()));
                }
                using(var ms = new MemoryStream()){
                    img = Image.FromFile("Yamaha.jpg");
                    img.Save(ms, img.RawFormat);
                    context.Add(new VehicleImage(6, ms.ToArray()));
                }
                using(var ms = new MemoryStream()){
                    img = Image.FromFile("Cruze RS.jpg");
                    img.Save(ms, img.RawFormat);
                    context.Add(new VehicleImage(7, ms.ToArray()));
                }
                using(var ms = new MemoryStream()){
                    img = Image.FromFile("Nueva Saveiro.jpg");
                    img.Save(ms, img.RawFormat);
                    context.Add(new VehicleImage(8, ms.ToArray()));
                }
                using(var ms = new MemoryStream()){
                    img = Image.FromFile("Fiat Pulse.jpg");
                    img.Save(ms, img.RawFormat);
                    context.Add(new VehicleImage(2, ms.ToArray()));
                }
                using(var ms = new MemoryStream()){
                    img = Image.FromFile("Nissan Versa 1.jpg");
                    img.Save(ms, img.RawFormat);
                    context.Add(new VehicleImage(9, ms.ToArray()));
                }
                using(var ms = new MemoryStream()){
                    img = Image.FromFile("Nissan Versa 2.jpg");
                    img.Save(ms, img.RawFormat);
                    context.Add(new VehicleImage(9, ms.ToArray()));
                }
                using(var ms = new MemoryStream()){
                    img = Image.FromFile("Nissan Versa 3.jpeg");
                    img.Save(ms, img.RawFormat);
                    context.Add(new VehicleImage(9, ms.ToArray()));
                }
                using(var ms = new MemoryStream()){
                    img = Image.FromFile("404.jpg");
                    img.Save(ms, img.RawFormat);
                    context.Add(new VehicleImage(1, ms.ToArray()));
                }
                context.SaveChanges();
            }
        }

        using(OMBContext context = new OMBContext()){
        if((context.VehiclesHistory.Count() == 0) && (context.ShipsHistory.Count() == 0)){
            context.Add(new VehicleHistory(3, "Auto", "STU901", "Eléctrico, nuevo", "Nueva Saveiro", 120000, 3));
            context.Add(new VehicleHistory(3, "Auto", "VWX234", "Gran capacidad de carga", "Nissan Versa", 70000, 5));
            context.Add(new ShipHistory(3, "Catamaran", "POR175", "En buenas condiciones, motor de alta potencia con poco consumo de combustible", "Marinello Eden 18", 1, 2, 3, true));
            context.Add(new ShipHistory(3, "Lancha", "QFT459", "Practicamente nuevo, ideal para salidas veraniegas", "Flyer 9 SUNdeck", 7, 6, 23, false));
            context.Add(new VehicleHistory(2, "Auto", "ABC123", "En buen estado", "Fiat Pulse", 90000, 3));
            context.Add(new VehicleHistory(2, "Ciclomotor", "DEF456", "Pocos kms", "Honda Accord Hybrid", 5000, 0));
            context.Add(new VehicleHistory(2, "Camioneta", "GHI789", "Excelente estado", "GR Yaris", 110000, 5));
            context.Add(new VehicleHistory(2, "Auto", "JKL012", "Con cambio automático", "Ford Kuga Hibrida", 80000, 5));
            context.Add(new VehicleHistory(2, "Ciclomotor", "MNO345", "A prueba de granizo y golpes leves", "Yamaha XTZ 250", 25000, 0));
            context.Add(new VehicleHistory(2, "Camioneta", "PQR678", "Buen motor, funciona con cualquier combustible", "Cruze RS", 95000, 5));
            context.Add(new ShipHistory(2, "Crucero", "ABC123", "Capacidad maxima de 150 personas", "Antares 9 OB", 15, 20, 25, true));
            context.Add(new ShipHistory(2, "Velero", "DBE030", "Muy veloz", "Oceanis 461", 10, 15, 20, false));
            context.Add(new ShipHistory(2, "Catamaran", "XFK535", "Apto para aguas agitadas, buena cobertura", "First 40.7", 20, 25, 30, true));
            context.Add(new ShipHistory(2, "Lancha", "LKM792", "Modelo clásico y resistente, buena capacidad de carga", "242 GTO", 5, 10, 15, false));
            context.Add(new ShipHistory(2, "Crucero", "RTS222", "Es un modelo muy seguro, y muy fácil de conducir, ideal para principiantes", "188 JOY", 2, 3, 4, true));
            context.Add(new ShipHistory(2, "Velero", "VYW323", "Espacio para dos personas, muy cómodo y muy rápido", "Cranchi Endurance 33", 4, 3, 2, false));
            context.SaveChanges();
        }
        }

        using(OMBContext context = new OMBContext()){
            if(context.Offers.Count() == 0){
                context.Add(new Offer(8, 11){state="accepted"});
                context.Add(new Offer(9, 12){state="accepted"});
                context.Add(new Offer(7, 17){state="accepted"});
                context.Add(new Offer(6, 18){state="accepted"});
                context.Add(new Offer(5, 3));
                context.SaveChanges();
            }
        }

        using(OMBContext context = new OMBContext()){
            if(context.UnresolvedExchanges.Count() == 0){
                context.Add(new UnresolvedExchange(8, 11){state="Accepted", sedeId=1, fechaYHora=DateTime.Now.Date.AddDays(-3)});
                context.Add(new UnresolvedExchange(9, 12){state="Accepted", sedeId=1, fechaYHora=DateTime.Now.Date.AddDays(-5)});
                context.Add(new UnresolvedExchange(7, 17){state="Accepted", sedeId=2, fechaYHora=DateTime.Now.Date.AddDays(-7)});
                context.Add(new UnresolvedExchange(6, 18));
                context.SaveChanges();
            }
        }

        using(OMBContext context = new OMBContext()){
            if(context.ResolvedExchanges.Count() == 0){
                Random random = new Random();
                for (int i = 0; i < 100; i++) {
                    int randomNumber = random.Next(2);
                    bool randomBoolean = randomNumber == 0 ? false : true;
                    int posted = (int)random.NextInt64(4) + 1;
                    int offered = (int)random.NextInt64(6) + 11;
                    context.Add(new ResolvedExchange((int)random.NextInt64(3) + 1, posted, offered, randomBoolean));
                }
            }
            context.SaveChanges();
        }
        #pragma warning restore CA1416
    }

}
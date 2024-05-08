namespace OMB.Repositories;

using OMB.Aplication.ClasesBase;
using OMB.Aplication.Interfaces;
using Microsoft.EntityFrameworkCore;

public class VehicleRepository : IVehicleRepository{
    
        private IVehiclePostRepository VPRep;

        public VehicleRepository(IVehiclePostRepository VPRep){
            this.VPRep = VPRep;
        }
        public void addVehicle (Vehicle vehicle){
        using(OMBContext context = new OMBContext()){
            var exists = context.Vehicles.Where(V => V.plate == vehicle.plate).SingleOrDefault();
            if(exists == null){
                context.Add(Clone(vehicle));
                context.SaveChanges();
            }
            else{
                throw new Exception("Plate number already registered");
            }
        }
    }
    public void deleteVehicle (int vehicleId){
        List<VehiclePost> posts = new List<VehiclePost>();
        using(OMBContext context = new OMBContext()){
            var exists = context.Vehicles.Include(S => S.VehiclePosts).Where(V => V.Id == vehicleId).SingleOrDefault();
            if(exists != null){
                posts = exists.VehiclePosts;
            }
        }
        foreach(VehiclePost p in posts){
            this.VPRep.deleteVehiclePost(p.Id);
        }
        using(OMBContext context = new OMBContext()){
            var exists = context.Vehicles.Where(V => V.Id == vehicleId).SingleOrDefault();
            if(exists != null){
                context.Remove(exists);
                context.SaveChanges();
            }
        }
    }
    public void modifyVehicle (Vehicle vehicle){
        using(OMBContext context = new OMBContext()){
            var exists = context.Vehicles.Where(V => V.Id == vehicle.Id).SingleOrDefault();
            Vehicle? aux = null;
            if(exists != null){
                if(vehicle.plate != exists.plate){
                    aux = context.Vehicles.Where(V => V.plate == vehicle.plate).SingleOrDefault();
                }
                if(aux == null){
                    exists.doors = vehicle.doors;
                    exists.kms = vehicle.kms;
                    exists.model = vehicle.model;
                    exists.type = vehicle.type;
                    exists.description = vehicle.description;
                    exists.plate = vehicle.plate;
                    context.SaveChanges();
                }
                else{
                    throw new Exception("This plate is already in our database");
                }
            }
        }
    }

    public List<Vehicle> VehicleList (){
        using(OMBContext context = new OMBContext()){
            List<Vehicle> Ret = new List<Vehicle>();
            List<Vehicle> Ori = context.Vehicles.ToList();
            foreach (Vehicle vehicle in Ori)
                Ret.Add(Clone(vehicle));
            return Ret;
        }
    }

    private Vehicle Clone(Vehicle vehicle){
        return new Vehicle(vehicle.UserId, vehicle.type, vehicle.plate, vehicle.description, vehicle.model, vehicle.kms, vehicle.doors){Id = vehicle.Id};
    }
}

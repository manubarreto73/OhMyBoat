namespace OMB.Repositories;

using OMB.Aplication.ClasesBase;
using OMB.Aplication.Interfaces;
using Microsoft.EntityFrameworkCore;

public class VehicleRepository : IVehicleRepository{
    
    private IPostRepository VPRep;
    private IVehicleImageRepository VIRep;

    public VehicleRepository(IPostRepository VPRep, IVehicleImageRepository VIRep){
        this.VPRep = VPRep;
        this.VIRep = VIRep;
    }
    public void addVehicle (Vehicle vehicle){
        using(OMBContext context = new OMBContext()){
            var exists = context.Vehicles.Where(V => V.plate == vehicle.plate).SingleOrDefault();
            if(exists == null){
                context.Vehicles.Add((Vehicle)vehicle.Clone());
                context.SaveChanges();
            }
            else{
                throw new Exception("Plate number already registered");
            }
        }
    }
    public void deleteVehicle (int vehicleId){
        Post? p = null;
        using(OMBContext context = new OMBContext()){
            var exists = context.Vehicles.Include(S => S.post).Where(V => V.Id == vehicleId).SingleOrDefault();
            if(exists != null){
                p = exists.post;
            }
        }
        if(p != null)
            this.VPRep.deletePost(p.Id);

        List<VehicleImage> images = new List<VehicleImage>();
        using(OMBContext context = new OMBContext()){
            var exists = context.Vehicles.Include(S => S.VehicleImages).Where(V => V.Id == vehicleId).SingleOrDefault();
            if(exists != null && exists.VehicleImages != null){
                images = exists.VehicleImages;
            }
        }
        foreach(VehicleImage vi in images) {
            this.VIRep.deleteVehicleImage(vi.Id);
        }

        using(OMBContext context = new OMBContext()){
            var exists = context.Vehicles.Where(V => V.Id == vehicleId).SingleOrDefault();
            if(exists != null){
                context.Vehicles.Remove(exists);
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
                Ret.Add((Vehicle)vehicle.Clone());
            return Ret;
        }
    }
}

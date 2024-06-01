namespace OMB.Repositories;

using OMB.Aplication.ClasesBase;
using OMB.Aplication.Interfaces;
using Microsoft.EntityFrameworkCore;

public class VehicleHistoryRepository : IVehicleHistoryRepository{
    public void addVehicle (VehicleHistory vehicle){
        using(OMBContext context = new OMBContext()){
            context.VehiclesHistory.Add(vehicle);
            context.SaveChanges();
        }
    }
    public void deleteVehicle (int vehicleId){
        using(OMBContext context = new OMBContext()){
            var exists = context.VehiclesHistory.Where(V => V.Id == vehicleId).SingleOrDefault();
            if(exists != null){
                context.VehiclesHistory.Remove(exists);
                context.SaveChanges();
            }
        }
    }
    public void modifyVehicle (VehicleHistory vehicle){
        using(OMBContext context = new OMBContext()){
            var exists = context.VehiclesHistory.Where(V => V.Id == vehicle.Id).SingleOrDefault();
            if(exists != null){
                exists.doors = vehicle.doors;
                exists.kms = vehicle.kms;
                exists.model = vehicle.model;
                exists.type = vehicle.type;
                exists.description = vehicle.description;
                exists.plate = vehicle.plate;
                context.SaveChanges();
            }
        }
    }

    public List<VehicleHistory> VehicleList (){
        using(OMBContext context = new OMBContext()){
            List<VehicleHistory> copia = new List<VehicleHistory>();
            List<VehicleHistory> original = context.VehiclesHistory.ToList();
            foreach (VehicleHistory vehicle in original)
                copia.Add((VehicleHistory)vehicle.Clone());
            return copia;
        }
    }
}
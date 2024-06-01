namespace OMB.Repositories;

using OMB.Aplication.Interfaces;
using OMB.Aplication.ClasesBase;
using Microsoft.EntityFrameworkCore;

public class ResolvedExchangeRepository : IResolvedExchangeRepository {
    
    private IVehicleHistoryRepository VHRep;
    private IShipHistoryRepository SHRep;

    public ResolvedExchangeRepository(IVehicleHistoryRepository VHRep, IShipHistoryRepository SHRep){
        this.VHRep = VHRep;
        this.SHRep = SHRep;
    }

    private void cargarAlHistorial (int Id) {
        using(OMBContext context = new OMBContext()){
            Vehicle? vehicle = context.Vehicles.Where(V => V.Id == Id).SingleOrDefault();
            if (vehicle != null) {
                VehicleHistory vehicleHistory = copyVehicle(vehicle);
                context.VehiclesHistory.Add((VehicleHistory)vehicleHistory.Clone());
            }
            else {
                Ship? ship = context.Ships.Where(S => S.Id == Id).SingleOrDefault();
                if (ship != null) {
                    ShipHistory shipHistory = copyShip(ship);
                    context.ShipsHistory.Add((ShipHistory)shipHistory.Clone());
                }
            }
        }
    }

    public void addResolvedExchange (ResolvedExchange resolvedExchange){
        cargarAlHistorial(resolvedExchange.transporteOfertadoId);
        cargarAlHistorial(resolvedExchange.transportePosteadoId);
        using(OMBContext context = new OMBContext()){
            context.ResolvedExchanges.Add((ResolvedExchange)resolvedExchange.Clone());
            context.SaveChanges();
        }
    }

    //Incompleto -> no borra los transportes correspondientes
    public void deleteResolvedExchange (int resolvedExchangeId){
        using(OMBContext context = new OMBContext()){
            var exists = context.ResolvedExchanges.Where(U => U.Id == resolvedExchangeId).SingleOrDefault();
            if(exists != null){
                context.Remove(exists);
                context.SaveChanges();
            }
        }
    }

    public List<ResolvedExchange> resolvedExchangeList (){
        using(OMBContext context = new OMBContext()){
            List<ResolvedExchange> copia = new List<ResolvedExchange>();
            List<ResolvedExchange> original = context.ResolvedExchanges.ToList();
            foreach (ResolvedExchange resolvedExchange in original)
                copia.Add((ResolvedExchange)resolvedExchange.Clone());
            return copia;
        }
    }

    public VehicleHistory copyVehicle (Vehicle V) {
        return new VehicleHistory(V.UserId, V.type, V.plate, V.description, V.model, V.kms, V.doors);
    }

    public ShipHistory copyShip (Ship S) {
        return new ShipHistory(S.UserId, S.type, S.plate, S.description, S.model, S.eslora, S.manga, S.calado, S.hasEngine);
    }
}
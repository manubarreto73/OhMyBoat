namespace OMB.Aplication.Interfaces;

using OMB.Aplication.ClasesBase;

public interface IVehicleHistoryRepository {

    public void addVehicle (Vehicle vehicle);
    public void deleteVehicle (int vehicleId);
    public void modifyVehicle (Vehicle vehicle); 
    public List<Vehicle> VehicleList ();

}
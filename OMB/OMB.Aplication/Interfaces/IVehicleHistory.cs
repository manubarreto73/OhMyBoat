namespace OMB.Aplication.Interfaces;

using OMB.Aplication.ClasesBase;

public interface IVehicleHistoryRepository {

    public void addVehicle (VehicleHistory vehicle);
    public void deleteVehicle (int vehicleId);
    public void modifyVehicle (VehicleHistory vehicle); 
    public List<VehicleHistory> VehicleList ();

}
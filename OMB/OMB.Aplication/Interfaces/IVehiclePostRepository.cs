namespace OMB.Aplication.Interfaces;

using OMB.Aplication.ClasesBase;

public interface IVehiclePostRepository {

    public void addVehiclePost (VehiclePost vehiclePost);
    public void deleteVehiclePost (int VehiclePostId);
    public void modifyVehiclePost (VehiclePost vehiclePost); 
    public List<VehiclePost> VehiclePostList ();

}
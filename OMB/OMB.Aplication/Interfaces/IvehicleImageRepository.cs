namespace OMB.Aplication.Interfaces;

using System.Drawing;
using OMB.Aplication.ClasesBase;

public interface IVehicleImageRepository {

    public void addVehicleImage (int Id, byte[] img);
    public void deleteVehicleImage (int VehicleImageId);
    public List<VehicleImage> listVehicleImages ();

}
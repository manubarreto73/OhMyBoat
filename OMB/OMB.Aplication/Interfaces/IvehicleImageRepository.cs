namespace OMB.Aplication.Interfaces;

using System.Drawing;
using OMB.Aplication.ClasesBase;

public interface IVehicleImageRepository {

    public void addVehicleImage (int Id, Image img);
    public List<VehicleImage> listVehicleImages ();

}
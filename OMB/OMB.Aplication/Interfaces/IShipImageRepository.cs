namespace OMB.Aplication.Interfaces;

using System.Drawing;
using OMB.Aplication.ClasesBase;

public interface IShipImageRepository {

    public void addShipImage (int Id, byte[] img);
    public void deleteShipImage (int ShipImageId);
    public List<ShipImage> listShipImages ();

}
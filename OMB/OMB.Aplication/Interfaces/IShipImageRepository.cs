namespace OMB.Aplication.Interfaces;

using System.Drawing;
using OMB.Aplication.ClasesBase;

public interface IShipImageRepository {

    public void addShipImage (int Id, byte[] img);
    public List<ShipImage> listShipImages ();

}
namespace OMB.Aplication.Interfaces;

using System.Drawing;
using OMB.Aplication.ClasesBase;

public interface IShipImageRepository {

    public void addShipImage (int Id, Image img);
    public List<ShipImage> listShipImages ();

}
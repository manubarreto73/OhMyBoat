namespace OMB.Aplication.Interfaces;

using OMB.Aplication.ClasesBase;

public interface IShipHistoryRepository {

    public void addShip (ShipHistory ship);
    public void deleteShip (int shipId);
    public void modifyShip (ShipHistory ship); 
    public List<ShipHistory> shipList ();

}
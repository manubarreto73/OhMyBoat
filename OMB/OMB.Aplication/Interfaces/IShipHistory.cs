namespace OMB.Aplication.Interfaces;

using OMB.Aplication.ClasesBase;

public interface IShipHistoryRepository {

    public void addShip (Ship ship);
    public void deleteShip (int shipId);
    public void modifyShip (Ship ship); 
    public List<Ship> shipList ();

}
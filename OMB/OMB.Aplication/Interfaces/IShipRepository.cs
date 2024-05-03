namespace OMB.Aplication.Interfaces;

using OMB.Aplication.ClasesBase;

public interface IShipRepository {

    public void addShip (Ship ship);
    public void deleteShip (string plate);
    public void modifyShip (Ship ship); 
    public List<Ship> ShipList ();

}
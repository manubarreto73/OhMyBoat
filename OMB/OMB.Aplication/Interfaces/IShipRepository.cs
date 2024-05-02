namespace OMB.Aplication.Interfaces.IShipRepository;

using OMB.Aplication.ClasesBase.Ship;

public interface IShipRepository {

    public void addShip (Ship ship);
    public void deleteShip (string matricula);
    public void modifyShip (Ship ship); 
    public List<Ship> ShipList ();

}
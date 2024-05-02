namespace OMB.Aplication.ShipUseCases;

using OMB.Aplication.ClasesBase.Ship;
using OMB.Aplication.Interfaces.IShipRepository;

public class modifyShipUseCase {

    public readonly IShipRepository repository;

    public modifyShipUseCase (IShipRepository repository) {
        this.repository = repository;
    }

    public void Ejecutar (Ship ship) {
        repository.modifyShip(ship);
    }

}
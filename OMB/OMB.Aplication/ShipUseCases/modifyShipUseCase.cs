namespace OMB.Aplication.ShipUseCases;

using OMB.Aplication.ClasesBase;
using OMB.Aplication.Interfaces;

public class modifyShipUseCase {

    public readonly IShipRepository repository;

    public modifyShipUseCase (IShipRepository repository) {
        this.repository = repository;
    }

    public void Execute (Ship ship) {
        repository.modifyShip(ship);
    }

}
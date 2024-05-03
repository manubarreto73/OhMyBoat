namespace OMB.Aplication.ShipUseCases;

using OMB.Aplication.ClasesBase;
using OMB.Aplication.Interfaces;

public class addShipUseCase {

    public readonly IShipRepository repository;

    public addShipUseCase (IShipRepository repository) {
        this.repository = repository;
    }

    public void Execute (Ship ship) {
        repository.addShip(ship);
    }

}
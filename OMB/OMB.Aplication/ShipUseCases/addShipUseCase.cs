namespace OMB.Aplication.ShipUseCases;

using OMB.Aplication.ClasesBase.Ship;
using OMB.Aplication.Interfaces.IShipRepository;

public class addShipUseCase {

    public readonly IShipRepository repository;

    public addShipUseCase (IShipRepository repository) {
        this.repository = repository;
    }

    public void Ejecutar (Ship ship) {
        repository.addShip(ship);
    }

}
namespace OMB.Aplication.ShipUseCases;

using OMB.Aplication.Interfaces;

public class deleteShipUseCase {

    public readonly IShipRepository repository;

    public deleteShipUseCase (IShipRepository repository) {
        this.repository = repository;
    }

    public void Execute (int id) {
        repository.deleteShip(id);
    }

}
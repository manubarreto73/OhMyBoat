namespace OMB.Aplication.ShipPostUseCases;

using OMB.Aplication.Interfaces;

public class deleteShipPostUseCase {

    public readonly IShipPostRepository repository;

    public deleteShipPostUseCase (IShipPostRepository repository) {
        this.repository = repository;
    }

    public void Execute (int id) {
        repository.deleteShipPost(id);
    }

}
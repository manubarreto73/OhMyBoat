namespace OMB.Aplication.ShipHistoryUseCases;

using OMB.Aplication.Interfaces;

public class deleteShipHistoryUseCase {

    public readonly IShipHistoryRepository repository;

    public deleteShipHistoryUseCase (IShipHistoryRepository repository) {
        this.repository = repository;
    }

    public void Execute (int id) {
        repository.deleteShip(id);
    }

}
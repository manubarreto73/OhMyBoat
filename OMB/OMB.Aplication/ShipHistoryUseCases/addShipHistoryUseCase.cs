namespace OMB.Aplication.ShipHistoryUseCases;

using OMB.Aplication.ClasesBase;
using OMB.Aplication.Interfaces;

public class addShipHistoryUseCase {

    public readonly IShipHistoryRepository repository;

    public addShipHistoryUseCase (IShipHistoryRepository repository) {
        this.repository = repository;
    }

    public void Execute (ShipHistory ship) {
        repository.addShip(ship);
    }

}
namespace OMB.Aplication.ShipHistoryUseCases;

using OMB.Aplication.ClasesBase;
using OMB.Aplication.Interfaces;

public class modifyShipHistoryUseCase {

    public readonly IShipHistoryRepository repository;

    public modifyShipHistoryUseCase (IShipHistoryRepository repository) {
        this.repository = repository;
    }

    public void Execute (ShipHistory ship) {
        repository.modifyShip(ship);
    }

}
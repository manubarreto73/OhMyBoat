namespace OMB.Aplication.ShipHistoryUseCases;

using OMB.Aplication.ClasesBase;
using OMB.Aplication.Interfaces;

public class shipHistoryListUseCase {

    public readonly IShipHistoryRepository repository;

    public shipHistoryListUseCase (IShipHistoryRepository repository) {
        this.repository = repository;
    }

    public List<ShipHistory> Execute () {
        return repository.shipList();
    }

}
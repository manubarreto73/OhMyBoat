namespace OMB.Aplication.ShipUseCases;

using OMB.Aplication.ClasesBase;
using OMB.Aplication.Interfaces;

public class shipListUseCase {

    public readonly IShipRepository repository;

    public shipListUseCase (IShipRepository repository) {
        this.repository = repository;
    }

    public List<Ship> Execute () {
        return repository.shipList();
    }

}
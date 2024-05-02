namespace OMB.Aplication.ShipUseCases;

using OMB.Aplication.ClasesBase.Ship;
using OMB.Aplication.Interfaces.IShipRepository;

public class shipListUseCase {

    public readonly IShipRepository repository;

    public shipListUseCase (IShipRepository repository) {
        this.repository = repository;
    }

    public List<Ship> Ejecutar () {
        return repository.ShipList();
    }

}
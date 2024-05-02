namespace OMB.Aplication.ShipUseCases;

using OMB.Aplication.Interfaces.IShipRepository;

public class deleteShipUseCase {

    public readonly IShipRepository repository;

    public deleteShipUseCase (IShipRepository repository) {
        this.repository = repository;
    }

    public void Ejecutar (string matricula) {
        repository.deleteShip(matricula);
    }

}
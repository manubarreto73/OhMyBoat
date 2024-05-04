namespace OMB.Aplication.ShipPostUseCases;

using OMB.Aplication.ClasesBase;
using OMB.Aplication.Interfaces;

public class addShipPostUseCase {

    public readonly IShipPostRepository repository;

    public addShipPostUseCase (IShipPostRepository repository) {
        this.repository = repository;
    }

    public void Execute (ShipPost shipPost) {
        repository.addShipPost(shipPost);
    }

}
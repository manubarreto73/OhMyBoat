namespace OMB.Aplication.ShipPostUseCases;

using OMB.Aplication.ClasesBase;
using OMB.Aplication.Interfaces;

public class modifyShipPostUseCase {

    public readonly IShipPostRepository repository;

    public modifyShipPostUseCase (IShipPostRepository repository) {
        this.repository = repository;
    }

    public void Execute (ShipPost ShipPost) {
        repository.modifyShipPost(ShipPost);
    }

}
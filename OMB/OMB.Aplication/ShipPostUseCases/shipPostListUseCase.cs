namespace OMB.Aplication.shipPostUseCases;

using OMB.Aplication.ClasesBase;
using OMB.Aplication.Interfaces;

public class shipPostListUseCase {

    public readonly IShipPostRepository repository;

    public shipPostListUseCase (IShipPostRepository repository) {
        this.repository = repository;
    }

    public List<ShipPost> Execute () {
        return repository.ShipPostList();
    }

}
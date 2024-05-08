namespace OMB.Aplication.ShipImageUseCases;

using OMB.Aplication.ClasesBase;
using OMB.Aplication.Interfaces;

public class listShipImagesUseCase {

    public readonly IShipImageRepository repository;

    public listShipImagesUseCase (IShipImageRepository repository) {
        this.repository = repository;
    }

    public List<ShipImage> Execute () {
        return repository.listShipImages();
    }

}
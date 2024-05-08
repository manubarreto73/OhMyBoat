namespace OMB.Aplication.VehicleImageUseCases;

using OMB.Aplication.ClasesBase;
using OMB.Aplication.Interfaces;

public class listVehicleImagesUseCase {

    public readonly IVehicleImageRepository repository;

    public listVehicleImagesUseCase (IVehicleImageRepository repository) {
        this.repository = repository;
    }

    public List<VehicleImage> Execute () {
        return repository.listVehicleImages();
    }

}
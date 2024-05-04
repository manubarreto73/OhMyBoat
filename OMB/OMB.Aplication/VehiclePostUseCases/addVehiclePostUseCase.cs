namespace OMB.Aplication.VehiclePostUseCases;

using OMB.Aplication.ClasesBase;
using OMB.Aplication.Interfaces;

public class addVehiclePostUseCase {

    public readonly IVehiclePostRepository repository;

    public addVehiclePostUseCase (IVehiclePostRepository repository) {
        this.repository = repository;
    }

    public void Execute (VehiclePost vehiclePost) {
        repository.addVehiclePost(vehiclePost);
    }
}
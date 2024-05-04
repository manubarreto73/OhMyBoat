namespace OMB.Aplication.VehiclePostUseCases;

using OMB.Aplication.ClasesBase;
using OMB.Aplication.Interfaces;

public class modifyVehiclePostUseCase {

    public readonly IVehiclePostRepository repository;

    public modifyVehiclePostUseCase (IVehiclePostRepository repository) {
        this.repository = repository;
    }

    public void Execute (VehiclePost vehiclePost) {
        repository.modifyVehiclePost(vehiclePost);
    }
}
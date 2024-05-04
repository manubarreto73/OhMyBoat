namespace OMB.Aplication.VehiclePostUseCases;

using OMB.Aplication.Interfaces;

public class deleteVehiclePostUseCase {

    public readonly IVehiclePostRepository repository;

    public deleteVehiclePostUseCase (IVehiclePostRepository repository) {
        this.repository = repository;
    }

    public void Execute (int id) {
        repository.deleteVehiclePost(id);
    }
}
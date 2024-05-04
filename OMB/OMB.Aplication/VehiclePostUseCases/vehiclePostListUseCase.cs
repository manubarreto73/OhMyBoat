namespace OMB.Aplication.VehiclePostUseCases;

using OMB.Aplication.ClasesBase;
using OMB.Aplication.Interfaces;

public class vehiclePostListUseCase {

    public readonly IVehiclePostRepository repository;

    public vehiclePostListUseCase (IVehiclePostRepository repository) {
        this.repository = repository;
    }

    public List<VehiclePost> Execute () {
        return repository.VehiclePostList();
    }
}
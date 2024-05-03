namespace OMB.Aplication.VehicleUseCases;

using OMB.Aplication.ClasesBase;
using OMB.Aplication.Interfaces;

public class vehicleListUseCase {

    public readonly IVehicleRepository repository;

    public vehicleListUseCase (IVehicleRepository repository) {
        this.repository = repository;
    }

    public List<Vehicle> Execute () {
        return repository.VehicleList();
    }
}
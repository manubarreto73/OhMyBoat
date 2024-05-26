namespace OMB.Aplication.VehicleUseCases;

using OMB.Aplication.ClasesBase;
using OMB.Aplication.Interfaces;

public class vehicleHistoryListUseCase {

    public readonly IVehicleHistoryRepository repository;

    public vehicleHistoryListUseCase (IVehicleHistoryRepository repository) {
        this.repository = repository;
    }

    public List<Vehicle> Execute () {
        return repository.VehicleList();
    }
}
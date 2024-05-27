namespace OMB.Aplication.VehicleHistoryUseCases;

using OMB.Aplication.ClasesBase;
using OMB.Aplication.Interfaces;

public class addVehicleHistoryUseCase {

    public readonly IVehicleHistoryRepository repository;

    public addVehicleHistoryUseCase (IVehicleHistoryRepository repository) {
        this.repository = repository;
    }

    public void Execute (VehicleHistory vehicle) {
        repository.addVehicle(vehicle);
    }
}
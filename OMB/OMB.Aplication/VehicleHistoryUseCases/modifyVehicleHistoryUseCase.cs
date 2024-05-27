namespace OMB.Aplication.VehicleUseCases;

using OMB.Aplication.ClasesBase;
using OMB.Aplication.Interfaces;

public class modifyVehicleHistoryUseCase {

    public readonly IVehicleHistoryRepository repository;

    public modifyVehicleHistoryUseCase (IVehicleHistoryRepository repository) {
        this.repository = repository;
    }

    public void Execute (VehicleHistory vehicle) {
        repository.modifyVehicle(vehicle);
    }
}
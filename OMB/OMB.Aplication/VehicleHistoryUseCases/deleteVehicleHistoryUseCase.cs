namespace OMB.Aplication.VehicleHistoryUseCases;

using OMB.Aplication.Interfaces;

public class deleteVehicleHistoryUseCase {

    public readonly IVehicleHistoryRepository repository;

    public deleteVehicleHistoryUseCase (IVehicleHistoryRepository repository) {
        this.repository = repository;
    }

    public void Execute (int id) {
        repository.deleteVehicle(id);
    }
}
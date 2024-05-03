namespace OMB.Aplication.VehicleUseCases;

using OMB.Aplication.Interfaces;

public class deleteVehicleUseCase {

    public readonly IVehicleRepository repository;

    public deleteVehicleUseCase (IVehicleRepository repository) {
        this.repository = repository;
    }

    public void Execute (string plate) {
        repository.deleteVehicle(plate);
    }
}
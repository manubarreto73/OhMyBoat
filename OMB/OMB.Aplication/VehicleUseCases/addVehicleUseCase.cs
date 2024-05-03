namespace OMB.Aplication.VehicleUseCases;

using OMB.Aplication.ClasesBase;
using OMB.Aplication.Interfaces;

public class addVehicleUseCase {

    public readonly IVehicleRepository repository;

    public addVehicleUseCase (IVehicleRepository repository) {
        this.repository = repository;
    }

    public void Execute (Vehicle vehicle) {
        repository.addVehicle(vehicle);
    }
}
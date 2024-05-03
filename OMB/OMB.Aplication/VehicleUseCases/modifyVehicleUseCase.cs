namespace OMB.Aplication.VehicleUseCases;

using OMB.Aplication.ClasesBase;
using OMB.Aplication.Interfaces;

public class modifyVehicleUseCase {

    public readonly IVehicleRepository repository;

    public modifyVehicleUseCase (IVehicleRepository repository) {
        this.repository = repository;
    }

    public void Execute (Vehicle vehicle) {
        repository.modifyVehicle(vehicle);
    }
}
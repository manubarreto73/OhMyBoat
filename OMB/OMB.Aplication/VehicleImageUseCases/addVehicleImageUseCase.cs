namespace OMB.Aplication.VehicleImageUseCases;

using System.Drawing;
using OMB.Aplication.ClasesBase;
using OMB.Aplication.Interfaces;

public class addVehicleImageUseCase {

    public readonly IVehicleImageRepository repository;
    public addVehicleImageUseCase (IVehicleImageRepository repository) {
        this.repository = repository;
    }

    public void Execute (int Id, byte[] img) {
        repository.addVehicleImage(Id, img);
    }

}
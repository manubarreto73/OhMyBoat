namespace OMB.Aplication.ShipImageUseCases;

using System.Drawing;
using OMB.Aplication.ClasesBase;
using OMB.Aplication.Interfaces;

public class addShipImageUseCase {

    public readonly IShipImageRepository repository;

    public addShipImageUseCase (IShipImageRepository repository) {
        this.repository = repository;
    }

    public void Execute (int Id, byte[] img) {
        repository.addShipImage(Id, img);
    }

}
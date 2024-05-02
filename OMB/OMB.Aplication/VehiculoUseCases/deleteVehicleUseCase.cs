namespace OMB.Aplication.CarUseCases;

using OMB.Aplication.Interfaces.IVehicleRepository;

public class deleteCarUseCase {

    public readonly IVehicleRepository repository;

    public deleteCarUseCase (IVehicleRepository repository) {
        this.repository = repository;
    }

    public void Ejecutar (string patente) {
        repository.deleteCar(patente);
    }

    //Elijo ponerle de nombre a los useCases como vehicle, aunque llamen a metodos de la clase car, 
    //para que sea más claro para quien haga los repositorios

}
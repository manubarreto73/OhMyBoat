namespace OMB.Aplication.CarUseCases;

using OMB.Aplication.ClasesBase.Car;
using OMB.Aplication.Interfaces.IVehicleRepository;

public class modifyCarUseCase {

    public readonly IVehicleRepository repository;

    public modifyCarUseCase (IVehicleRepository repository) {
        this.repository = repository;
    }

    public void Ejecutar (Car Car) {
        repository.modifyCar(Car);
    }

    //Elijo ponerle de nombre a los useCases como vehicle, aunque llamen a metodos de la clase car, 
    //para que sea más claro para quien haga los repositorios

}
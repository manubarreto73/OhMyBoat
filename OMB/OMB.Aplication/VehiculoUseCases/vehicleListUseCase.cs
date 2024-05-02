namespace OMB.Aplication.CarUseCases;

using OMB.Aplication.ClasesBase.Car;
using OMB.Aplication.Interfaces.IVehicleRepository;

public class vehicleListUseCase {

    public readonly IVehicleRepository repository;

    public vehicleListUseCase (IVehicleRepository repository) {
        this.repository = repository;
    }

    public List<Car> Ejecutar () {
        return repository.CarList();
    }

    //Elijo ponerle de nombre a los useCases como vehicle, aunque llamen a metodos de la clase car, 
    //para que sea más claro para quien haga los repositorios

}
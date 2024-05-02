namespace OMB.Aplication.Interfaces.IVehicleRepository;

using OMB.Aplication.ClasesBase.Car;

public interface IVehicleRepository {

    public void addCar (Car car);
    public void deleteCar (string patente);
    public void modifyCar (Car Car); 
    public List<Car> CarList ();

    //Dado que decidimos que en la BD habrá una tabla de autos, donde también estarán las motos y tendrán un atributo opcional "puertas",
    //Creé la interfaz vehículos que maneja la clase Car. Es la única que vamos a usar realmente, la clase motocycle no va a ser usada
    //De lo último me acabo de dar cuenta mientras escribía esto jsjsjs


}
namespace OMB.Aplication.Interfaces;

using OMB.Aplication.ClasesBase;

public interface IVehicleRepository {

    public void addVehicle (Vehicle vehicle);
    public void deleteVehicle (string plate);
    public void modifyVehicle (Vehicle vehicle); 
    public List<Vehicle> VehicleList ();

    //Dado que decidimos que en la BD habrá una tabla de autos, donde también estarán las motos y tendrán un atributo opcional "puertas",
    //Creé la interfaz vehículos que maneja la clase Car. Es la única que vamos a usar realmente, la clase motocycle no va a ser usada
    //De lo último me acabo de dar cuenta mientras escribía esto jsjsjs


}
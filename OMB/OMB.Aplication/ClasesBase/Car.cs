namespace OMB.Aplication.ClasesBase.Car;

using Motocycle;

public class Car : Motocycle {

    public int doors {get; set;}

    public Car (string model, double kms, string patente, int doors) : base(model, kms, patente) {
        this.doors = doors;
    }

}
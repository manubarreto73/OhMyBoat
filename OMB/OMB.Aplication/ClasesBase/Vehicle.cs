namespace OMB.Aplication.ClasesBase;
public class Vehicle : Transport {

    public double kms {get; set;}
    public int doors {get; set;}
    public List<VehicleImage>? VehicleImages {get; set;}

    public Vehicle (int UserId, string type, string plate, string description, string model, double kms, int doors) : base(UserId, type, model, plate, description) {
        this.kms = kms;
        this.doors = doors;
    }

    public Vehicle() : base() {}

    public override IClonable Clone(){
        return new Vehicle(this.UserId, this.type, this.plate, this.description, this.model, this.kms, this.doors){Id = this.Id};
    }

}
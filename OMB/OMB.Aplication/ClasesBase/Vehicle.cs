namespace OMB.Aplication.ClasesBase;

public class Vehicle : Transport {

    public string model {get; set;}
    public double kms {get; set;}
    public int doors {get; set;}
    public List<VehiclePost>? VehiclePosts {get; set;}

    public Vehicle (int UserId, string type, string plate, string description, string model, double kms, int doors) : base(UserId, type, plate, description) {
        this.model = model;
        this.kms = kms;
        this.doors = doors;
    }

}
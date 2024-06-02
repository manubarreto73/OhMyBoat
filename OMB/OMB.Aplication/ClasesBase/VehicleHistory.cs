namespace OMB.Aplication.ClasesBase;
public class VehicleHistory : TransportHistory {

    public double kms {get; set;}
    public int doors {get; set;}

    public VehicleHistory (int UserId, string type, string plate, string description, string model, double kms, int doors) : base(UserId, type, plate, description, model) {
        this.kms = kms;
        this.doors = doors;
    }

    public VehicleHistory() : base() {}

    public override IClonable Clone(){
        return new VehicleHistory(this.UserId, this.type, this.plate, this.description, this.model, this.kms, this.doors){Id = this.Id};
    }

}
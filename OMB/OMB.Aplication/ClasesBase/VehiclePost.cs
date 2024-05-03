namespace OMB.Aplication.ClasesBase;

public class VehiclePost{
    public int Id {get; set;} //No sé si sirve de algo
    public int VehicleId {get; set;}
    public DateTime posted {get; set;}

    public VehiclePost(int VehicleId){
        this.VehicleId = VehicleId;
        this.posted = DateTime.Now; //Creo que esto está bien??
    }
}
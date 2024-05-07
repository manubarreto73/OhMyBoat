namespace OMB.Aplication.ClasesBase;

public class VehiclePost{
    public int Id {get; set;} //No sé si sirve de algo
    public string Title {get; set;}
    public int VehicleId {get; set;}
    public DateTime posted {get; set;}

    public VehiclePost(int VehicleId, string Title){
        this.VehicleId = VehicleId;
        this.Title = Title;
        this.posted = DateTime.Now; //Creo que esto está bien??
    }
}
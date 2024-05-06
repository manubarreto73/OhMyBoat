namespace OMB.Aplication.ClasesBase;

public class VehicleImage{
    public int Id {get; set;}
    public int VehicleId{get; set;}
    public byte[] Image {get; set;}

    public VehicleImage(int VehicleId, byte[] Image){
        this.VehicleId = VehicleId;
        this.Image = Image;
    }
}
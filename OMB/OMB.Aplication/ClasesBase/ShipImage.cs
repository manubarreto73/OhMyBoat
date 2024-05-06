namespace OMB.Aplication.ClasesBase;

public class ShipImage{
    public int Id {get; set;}
    public int ShipId{get; set;}
    public byte[] Image {get; set;}

    public ShipImage(int ShipId, byte[] Image){
        this.ShipId = ShipId;
        this.Image = Image;
    }
}
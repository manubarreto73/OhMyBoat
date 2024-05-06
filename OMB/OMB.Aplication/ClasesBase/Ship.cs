namespace OMB.Aplication.ClasesBase;
public class Ship : Transport {
    
    public double eslora {get; set;}
    public double manga {get; set;}
    public double calado {get; set;}
    public bool hasEngine {get; set;}
    public List<ShipPost>? ShipPosts {get; set;}
    public List<ShipImage>? ShipImages{get; set;}

    public Ship (int UserId, string type, string plate, string description, double eslora, double manga, double calado, bool hasEngine) : base(UserId, type, plate, description){
        this.eslora = eslora;
        this.manga = manga;
        this.calado = calado;
        this.hasEngine = hasEngine;
    }

}
namespace OMB.Aplication.ClasesBase;
public class Ship : Transport {
    
    public double eslora {get; set;}
    public double manga {get; set;}
    public double calado {get; set;}
    public bool hasEngine {get; set;}
    public List<ShipImage>? ShipImages{get; set;}

    public Ship (int UserId, string type, string plate, string description, string model, double eslora, double manga, double calado, bool hasEngine) : base(UserId, type, model, plate, description){
        this.eslora = eslora;
        this.manga = manga;
        this.calado = calado;
        this.hasEngine = hasEngine;
    }

    public Ship() : base() {}
    
    public override IClonable Clone() {
        return new Ship(this.UserId, this.type, this.plate, this.description, this.model, this.eslora, this.manga, this.calado, this.hasEngine){Id = this.Id};
    }
}
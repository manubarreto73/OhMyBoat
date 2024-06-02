namespace OMB.Aplication.ClasesBase;
public class ShipHistory : TransportHistory {
    
    public double eslora {get; set;}
    public double manga {get; set;}
    public double calado {get; set;}
    public bool hasEngine {get; set;}

    public ShipHistory (int UserId, string type, string plate, string description, string model, double eslora, double manga, double calado, bool hasEngine) : base(UserId, type, plate, description, model){
        this.eslora = eslora;
        this.manga = manga;
        this.calado = calado;
        this.hasEngine = hasEngine;
    }

    public ShipHistory() : base() {}
    
    public override IClonable Clone() {
        return new ShipHistory(this.UserId, this.type, this.plate, this.description, this.model, this.eslora, this.manga, this.calado, this.hasEngine){Id = this.Id};
    }
}
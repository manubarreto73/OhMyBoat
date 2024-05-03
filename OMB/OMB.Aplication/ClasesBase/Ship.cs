namespace OMB.Aplication.ClasesBase;

using System.Drawing;

public class Ship : Transport {
    
    public double eslora {get; set;}
    public double manga {get; set;}
    public double calado {get; set;}
    public bool hasEngine {get; set;}

    public Ship (string type, string plate, string description, double eslora, double manga, double calado, bool hasEngine) : base(type, plate, description){
        this.eslora = eslora;
        this.manga = manga;
        this.calado = calado;
        this.hasEngine = hasEngine;
    }

}
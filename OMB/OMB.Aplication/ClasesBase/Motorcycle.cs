namespace OMB.Aplication.ClasesBase.Motocycle;

public class Motocycle {

    public string model {get; set;}
    
    public double kms {get; set;}

    public string patente {get; set;}

    //Con el tema de las imagenes, lo mismo que escribi en la clase Ship

    public Motocycle (string model, double kms, string patente) {
        this.model = model;
        this.kms = kms;
        this.patente = patente;
    }

}
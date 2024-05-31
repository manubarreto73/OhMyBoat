namespace OMB.Aplication.ClasesBase;

public class Offer : IClonable {

    public int Id {get; set;}
    public string state {get; set;}
    public int transportePosteadoId {get; set;}
    public int transporteOfertadoId {get; set;}
    public Transport transportePosteado {get; set;}
    public Transport transporteOfertado {get; set;}

    public Offer (int transportePosteadoId, int transporteOfertadoId) {
        this.transporteOfertadoId = transporteOfertadoId;
        this.transportePosteadoId = transportePosteadoId;
        this.state = "active";
    }

    public IClonable Clone () {
        return new Offer (this.transportePosteadoId, this.transporteOfertadoId){Id = this.Id, state = this.state};
    }

}
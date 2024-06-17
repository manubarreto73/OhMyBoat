namespace OMB.Aplication.ClasesBase;

public class Offer : IClonable {

    public int Id {get; set;}
    public string state {get; set;}
    public int transportePosteadoId {get; set;}
    public int transporteOfertadoId {get; set;}
    public Transport? transportePosteado {get; set;}
    public Transport? transporteOfertado {get; set;}

    public Offer (int transportePosteadoId, int transporteOfertadoId) {
        this.transporteOfertadoId = transporteOfertadoId;
        this.transportePosteadoId = transportePosteadoId;
        this.state = "active";      // states are "active" and "paused"
    }
    public Offer () {
        this.transporteOfertadoId = 0;
        this.transportePosteadoId = 0;
        this.state = "empty";
    }

    public IClonable Clone () {
        return new Offer (this.transportePosteadoId, this.transporteOfertadoId){Id = this.Id, state = this.state};
    }

}
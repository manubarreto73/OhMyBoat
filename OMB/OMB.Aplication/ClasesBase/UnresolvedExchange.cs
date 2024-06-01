namespace OMB.Aplication.ClasesBase;

public class UnresolvedExchange : Exchange {

    public string state {get; set;}

    public int transportePosteadoId {get; set;}
    public int transporteOfertadoId {get; set;}
    public Transport transportePosteado {get; set;}
    public Transport transporteOfertado {get; set;}

    public UnresolvedExchange (int transportePosteadoId, int transporteOfertadoId) {
        this.transporteOfertadoId = transporteOfertadoId;
        this.transportePosteadoId = transportePosteadoId;
        state = "OffererStart";   // OffererStart | OffererChooses | OwnerChooses | Accepted | (posiblemente un Canceled tambien)
    }

    public override IClonable Clone(){
        return new UnresolvedExchange(this.transportePosteadoId, this.transporteOfertadoId){Id=this.Id, fechaYHora=this.fechaYHora, state=this.state, sede=this.sede};
    }

}
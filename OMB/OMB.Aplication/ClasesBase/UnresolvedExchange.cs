namespace OMB.Aplication.ClasesBase;

public class UnresolvedExchange : Exchange {

    public string state {get; set;}

    public UnresolvedExchange (int transportePosteadoId, int transporteOfertadoId) : base(transporteOfertadoId, transportePosteadoId) {
        state = "OffererStart";   // OffererStart | OffererChooses | OwnerChooses | Accepted | (posiblemente un Canceled tambien)
    }

    public override IClonable Clone(){
        return new UnresolvedExchange(this.transportePosteadoId, this.transporteOfertadoId){Id=this.Id, fechaYHora=this.fechaYHora, state=this.state, sede=this.sede};
    }

}
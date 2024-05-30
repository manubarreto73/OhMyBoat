namespace OMB.Aplication.ClasesBase;

public class UnresolvedExchange : Exchange {

    public string state {get; set;}

    public UnresolvedExchange (int transportePosteadoId, int transporteOfertadoId) : base(transporteOfertadoId, transportePosteadoId) {
        state = "chooseOfferer";
    }

    public override IClonable Clone(){
        return new UnresolvedExchange(this.transportePosteadoId, this.transporteOfertadoId);
    }

}
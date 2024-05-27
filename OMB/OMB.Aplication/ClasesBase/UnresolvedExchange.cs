namespace OMB.Aplication.ClasesBase;

public class UnresolvedExchange : Exchange{

    public UnresolvedExchange (int transportePosteadoId, int transporteOfertadoId) : base(transporteOfertadoId, transportePosteadoId) {
    }

    public override IClonable Clone(){
        return new UnresolvedExchange(this.transportePosteadoId, this.transporteOfertadoId);
    }

}
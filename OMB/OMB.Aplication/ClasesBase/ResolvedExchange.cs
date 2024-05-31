namespace OMB.Aplication.ClasesBase;

public class ResolvedExchange : Exchange{
    public bool happen {get; set;}

    public ResolvedExchange (int transportePosteadoId, int transporteOfertadoId, bool happen) : base(transporteOfertadoId, transportePosteadoId) {
        this.happen = happen;
    }

    public override IClonable Clone(){
        return new ResolvedExchange(this.transportePosteadoId, this.transporteOfertadoId, this.happen){Id = this.Id};
    }

}
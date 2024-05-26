namespace OMB.Aplication.ClasesBase;

public class ResolvedExchange : Exchange{
    public bool? happen {get; set;}

    public ResolvedExchange (int transportePosteadoId, int transporteOfertadoId) : base(transporteOfertadoId, transportePosteadoId) {
    }

}
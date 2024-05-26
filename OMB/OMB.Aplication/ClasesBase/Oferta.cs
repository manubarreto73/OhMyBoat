namespace OMB.Aplication.ClasesBase;

public class Offer{

    public int? Id {get; set;}
    public int? transportePosteadoId {get; set;}
    public int? transporteOfertadoId {get; set;}
    public Transport? transportePosteado {get; set;}
    public Transport? transporteOfertado {get; set;}

    public Offer (int transportePosteadoId, int transporteOfertadoId) {
        this.transporteOfertadoId = transporteOfertadoId;
        this.transportePosteadoId = transportePosteadoId;
    }

}
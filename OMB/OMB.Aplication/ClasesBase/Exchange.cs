namespace OMB.Aplication.ClasesBase;

public abstract class Exchange : IClonable{

    public int Id {get; set;}
    public int transportePosteadoId {get; set;}
    public int transporteOfertadoId {get; set;}
    public Transport transportePosteado {get; set;}
    public Transport transporteOfertado {get; set;}
    public DateTime fechaYHora {get; set;}
    public String sede {get; set;}

    public Exchange (int transportePosteadoId, int transporteOfertadoId) {
        this.transporteOfertadoId = transporteOfertadoId;
        this.transportePosteadoId = transportePosteadoId;
    }

    public abstract IClonable Clone();

}
namespace OMB.Aplication.ClasesBase;

public abstract class Exchange : IClonable{

    public int Id {get; set;}
    public int transportePosteadoId {get; set;}
    public int transporteOfertadoId {get; set;}
    public Transport transportePosteado {get; set;}
    public Transport transporteOfertado {get; set;}
    public DateTime fechaYHora {get; set;}
    public string? sede {get; set;} // Puede estar en Sede 1 a 4

    public Exchange (int transportePosteadoId, int transporteOfertadoId) {
        this.transporteOfertadoId = transporteOfertadoId;
        this.transportePosteadoId = transportePosteadoId;
        this.sede = "Sede 1";
        this.fechaYHora = DateTime.Now.Date;
    }

    public abstract IClonable Clone();

}
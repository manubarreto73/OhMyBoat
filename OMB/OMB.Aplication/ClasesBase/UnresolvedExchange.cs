namespace OMB.Aplication.ClasesBase;

public class UnresolvedExchange : Exchange
{

    public string state { get; set; }

    public int transportePosteadoId { get; set; }
    public int transporteOfertadoId { get; set; }
    public Transport? transportePosteado { get; set; }
    public Transport? transporteOfertado { get; set; }
    public int sedeId { get; set; } = 1; //Me pide que haya un Id acá por defecto. Nunca vamos a usarlo, no jode que esté linkeado a una sede por defecto
    public Sede? sede { get; set; }

    public UnresolvedExchange(int transportePosteadoId, int transporteOfertadoId) {
    this.transporteOfertadoId = transporteOfertadoId;
    this.transportePosteadoId = transportePosteadoId;
    this.state = "OffererStart";   // OffererStart | OffererChooses | OwnerChooses | Accepted | (posiblemente un Canceled tambien)
    }

    public override IClonable Clone() {
    return new UnresolvedExchange(this.transportePosteadoId, this.transporteOfertadoId) { Id = this.Id, fechaYHora = this.fechaYHora, state = this.state, sedeId = this.sedeId };
    }

}
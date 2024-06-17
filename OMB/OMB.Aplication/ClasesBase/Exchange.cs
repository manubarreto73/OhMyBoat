namespace OMB.Aplication.ClasesBase;

public abstract class Exchange : IClonable
{

    public int Id {get; set;}
    public DateTime fechaYHora {get; set;}

    public Exchange() => this.fechaYHora = DateTime.Now.Date;

    public abstract IClonable Clone();

}
namespace OMB.Aplication.ClasesBase;

public abstract class Exchange : IClonable{

    public int Id {get; set;}
    public DateTime fechaYHora {get; set;}
    public string? sede {get; set;} // Puede estar en Sede 1 a 4

    public Exchange () {
        this.sede = "Sede 1";
        this.fechaYHora = DateTime.Now.Date;
    }

    public abstract IClonable Clone();

}
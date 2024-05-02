namespace OMB.Aplication.ClasesBase.Ship;

using System.Drawing;

public class Ship {
    
    public double eslora {get; set;}
    
    public double manga {get; set;}
    
    public double calado {get; set;}

    public string matricula {get; set;}

    public Boolean tieneMotor {get; set;}

    //public List<Image> photos {get; set;}
    //supuestamente asi se agregaba imagenes pero no estaría workeando, lo resuelvo después
    //la lista de las imagenes no debería ser dinámica porque genera problemas en la BD, había una cantidad minima o maxima?

    public Ship (double eslora, double manga, double calado, string matricula, Boolean tieneMotor) {
        this.eslora = eslora;
        this.manga = manga;
        this.calado = calado;
        this.matricula = matricula;
        this.tieneMotor = tieneMotor;
    }

}
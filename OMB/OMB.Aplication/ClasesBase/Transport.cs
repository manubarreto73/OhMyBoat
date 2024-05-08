namespace OMB.Aplication.ClasesBase;

using System.Drawing;

public class Transport {

    public int Id {get; set;}
    public int UserId {get; set;}
    public string type {get; set;}
    public string plate {get; set;}
    public string description {get; set;}
    //public List<Image> photos {get; set;}
    //supuestamente asi se agregaba imagenes pero no estaría workeando, lo resuelvo después
    //la lista de las imagenes no debería ser dinámica porque genera problemas en la BD, había una cantidad minima o maxima?
    public Transport (int UserId, string type, string plate, string description){
        this.UserId = UserId;
        this.type = type;
        this.plate = plate;
        this.description = description;
    }

    public Transport() {}

}
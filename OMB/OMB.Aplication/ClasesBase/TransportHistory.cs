namespace OMB.Aplication.ClasesBase;

public abstract class TransportHistory : IClonable {

    public int Id {get; set;}
    public int UserId {get; set;}
    public string type {get; set;}
    public string plate {get; set;}
    public string description {get; set;}
    public User? owner{get; set;}
    public TransportHistory (int UserId, string type, string plate, string description){
        this.UserId = UserId;
        this.type = type;
        this.plate = plate;
        this.description = description;
    }
    public TransportHistory() {}
    public abstract IClonable Clone();

}
namespace OMB.Aplication.ClasesBase;

public abstract class Transport : IClonable {

    public int Id {get; set;}
    public int UserId {get; set;}
    public string type {get; set;} = "";
    public string plate {get; set;} = "";
    public string description {get; set;} = "";
    public string model {get; set;} = "";
    public User? owner{get; set;}
    public Post? post{get; set;}
    public Transport (int UserId, string type, string model, string plate, string description){
        this.model = model;
        this.UserId = UserId;
        this.type = type;
        this.plate = plate;
        this.description = description;
    }

    public Transport() {}
    public abstract IClonable Clone();

}
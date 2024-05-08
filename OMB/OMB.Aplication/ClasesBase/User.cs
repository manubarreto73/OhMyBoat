namespace OMB.Aplication.ClasesBase;

public class User : Employee{

    public bool banned {get; set;} = false;
    public List<Vehicle>? Vehicles {get; set;}
    public List<Ship>? Ships {get; set;}

    public User(string name, string surname, string userName, string password, string mail, string number, DateOnly birthDate) : base(name, surname, userName, password, mail, number, birthDate) {
    
    }

    public User(){
        
    }


}
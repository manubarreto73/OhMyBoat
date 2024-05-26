namespace OMB.Aplication.ClasesBase;

public class User : Persona {

    public List<Transport>? Transports {get; set;}
    public bool banned {get; set;} = false;

    public User(string name, string surname, string userName, string password, string mail, string number, DateOnly birthDate) : base(name, surname, userName, password, mail, number, birthDate) {
        this.banned = false;
    }

    public User() {}

}
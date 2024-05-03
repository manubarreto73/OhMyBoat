namespace OMB.Aplication.ClasesBase;

public class User {

    public int Id {get; set;} //En el proyecto del seminario lo inicializamos en -1, quizás sea importante
    public string name {get; set;}
    public string surname {get; set;}
    public string userName {get; set;}
    public string password {get; set;}
    public string mail {get; set;}
    public string number {get; set;}
    public bool banned {get; set;} = false;
    public DateTime birthDate {get; set;}
    public List<Vehicle>? Vehicles {get; set;}
    public List<Ship>? Ships {get; set;}

    public User(string name, string surname, string userName, string password, string mail, string number, DateTime birthDate) {
        this.name = name;
        this.surname = surname;
        this.userName = userName;
        this.password = password;
        this.mail = mail;
        this.number = number;
        this.birthDate = birthDate;
    }

}
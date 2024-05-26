namespace OMB.Aplication.ClasesBase;

public class User{

    public int Id {get; set;}
    public string name {get; set;}
    public string surname {get; set;}
    public string userName {get; set;}
    public string password {get; set;}
    public string mail {get; set;}
    public string number {get; set;}
    public DateOnly birthDate {get; set;}
    public bool banned {get; set;} = false;
    public List<Transport>? Transports {get; set;}

    public User(string name, string surname, string userName, string password, string mail, string number, DateOnly birthDate) {
        this.name = name;
        this.surname = surname;
        this.userName = userName;
        this.password = password;
        this.mail = mail;
        this.number = number;
        this.birthDate = birthDate;
        this.banned = false;
    }

    public User() {}

}
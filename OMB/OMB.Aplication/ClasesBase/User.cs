namespace OMB.Aplication.ClasesBase.User;

public class User {

    public int Id {get; set;} //En el proyecto del seminario lo inicializamos en -1, quizás sea importante
    public string name {get; set;}
    public string surname {get; set;}
    public string userName {get; set;}
    public string mail {get; set;}
    public string number {get; set;}
    public DateTime birthDate {get; set;}

    public User (string name, string surname, string userName, string mail, string number, DateTime birthDate) {
        this.name = name;
        this.surname = surname;
        this.userName = userName;
        this.mail = mail;
        this.number = number;
        this.birthDate = birthDate;
    }

}
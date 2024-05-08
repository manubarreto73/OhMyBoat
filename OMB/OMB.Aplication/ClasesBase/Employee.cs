namespace OMB.Aplication.ClasesBase;

public class Employee{
    public int Id {get; set;} //En el proyecto del seminario lo inicializamos en -1, quizás sea importante
    public string name {get; set;}
    public string surname {get; set;}
    public string userName {get; set;}
    public string password {get; set;}
    public string mail {get; set;}
    public string number {get; set;}
    public DateOnly birthDate {get; set;}

    public Employee(string name, string surname, string userName, string password, string mail, string number, DateOnly birthDate){
        this.name = name;
        this.surname = surname;
        this.userName = userName;
        this.password = password;
        this.mail = mail;
        this.number = number;
        this.birthDate = birthDate;
    }

    public Employee(){
        this.name = "";
        this.surname = "";
        this.userName = "";
        this.password = "";
        this.mail = "";
        this.number = "";
        this.birthDate = DateOnly.FromDateTime(DateTime.Now);
    }
}
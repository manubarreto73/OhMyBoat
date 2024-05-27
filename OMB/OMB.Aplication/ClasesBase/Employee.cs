namespace OMB.Aplication.ClasesBase;

public class Employee : Persona {

    public Employee(string name, string surname, string userName, string password, string mail, string number, DateOnly birthDate) : base(name, surname, userName, password, mail, number, birthDate) {
    }

    public Employee(){
    }
}
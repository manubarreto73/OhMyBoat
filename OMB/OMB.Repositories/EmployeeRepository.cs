namespace OMB.Repositories;

using OMB.Aplication.Interfaces;
using OMB.Aplication.ClasesBase;
using Microsoft.EntityFrameworkCore;

public class EmployeeRepository : IEmployeeRepository {

    public void addEmployee (Employee employee){
        using(OMBContext context = new OMBContext()){
            bool exists = (context.Employees.Where(E => E.userName == employee.userName).SingleOrDefault() != null) || (context.Users.Where(U => U.userName == employee.userName).SingleOrDefault() != null);
            if(!exists){
                exists = (context.Employees.Where(E => E.mail == employee.mail).SingleOrDefault() != null) || (context.Users.Where(U => U.mail == employee.mail).SingleOrDefault() != null);
                if(!exists){
                    context.Add(Clone(employee));
                }
                else{
                    throw new Exception("Mail already in use!");
                }
            }
            else{
                throw new Exception("This username's already taken!");
            }
            context.SaveChanges();
        }
    }
    public void deleteEmployee (int employeeId){
        using(OMBContext context = new OMBContext()){
            var exists = context.Employees.Where(E => E.Id == employeeId).SingleOrDefault();
            if(exists != null && employeeId != 0){
                context.Remove(exists);
                context.SaveChanges();
            }
        }
    }
    public void modifyEmployee (Employee employee){
        using(OMBContext context = new OMBContext()){
            var exists = context.Employees.Where(E => E.Id == employee.Id).SingleOrDefault();
            bool aux = false;
            if(exists != null){
                if(exists.userName != employee.userName){
                    aux = (context.Employees.Where(E => E.userName == employee.userName).SingleOrDefault() != null) || (context.Users.Where(U => U.userName == employee.userName).SingleOrDefault() != null);
                }
                if(!aux){
                    if(exists.mail != employee.mail){
                        aux = (context.Employees.Where(U => U.mail == employee.mail).SingleOrDefault() != null) || (context.Users.Where(U => U.mail == employee.mail).SingleOrDefault() != null);
                    }
                    if(!aux){
                        exists.mail = employee.mail;
                        exists.name = employee.name;
                        exists.surname = employee.surname;
                        exists.number = employee.number;
                        exists.userName = employee.userName;
                        exists.birthDate = employee.birthDate;
                        exists.password = employee.password;
                        context.SaveChanges();
                    }
                    else{
                        throw new Exception("This mail is already in use");
                    }
                }
                else{
                    throw new Exception("This username is taken");
                }
            }
        }
    }

    public List<Employee> employeeList (){
        using(OMBContext context = new OMBContext()){
            List<Employee> Ret = new List<Employee>();
            List<Employee> Ori = context.Employees.ToList();
            foreach (Employee Employee in Ori)
                Ret.Add(Clone(Employee));
            return Ret;
        }
    }

    private Employee Clone(Employee Employee){
        return new Employee(Employee.name, Employee.surname, Employee.userName, Employee.password, Employee.mail, Employee.number, Employee.birthDate){Id = Employee.Id};
    }
}

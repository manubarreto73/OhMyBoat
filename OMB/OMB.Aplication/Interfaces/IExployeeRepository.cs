namespace OMB.Aplication.Interfaces;

using OMB.Aplication.ClasesBase;

public interface IEmployeeRepository {

    public void addEmployee (Employee employee);
    public void deleteEmployee (int employeeId);
    public void modifyEmployee (Employee employee); 
    public List<Employee> employeeList ();

}
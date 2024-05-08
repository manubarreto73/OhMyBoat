namespace OMB.Aplication.Interfaces;

using OMB.Aplication.ClasesBase;

public interface IEmployeeRepository {

    public void addEmployee (Employee employee);
    public void deleteEmployee (int userId);
    public void modifyEmployee (Employee Employee); 
    public List<Employee> employeeList ();

}
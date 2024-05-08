namespace OMB.Aplication.EmployeeUseCases;

using OMB.Aplication.ClasesBase;
using OMB.Aplication.Interfaces;

public class addEmployeeUseCase {

    public readonly IEmployeeRepository repository;

    public addEmployeeUseCase (IEmployeeRepository repository) {
        this.repository = repository;
    }

    public void Execute (Employee employee) {
        repository.addEmployee(employee);
    }

}
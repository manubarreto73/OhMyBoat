namespace OMB.Aplication.EmployeeUseCases;

using OMB.Aplication.ClasesBase;
using OMB.Aplication.Interfaces;

public class EmployeeListUseCase {

    public readonly IEmployeeRepository repository;

    public EmployeeListUseCase (IEmployeeRepository repository) {
        this.repository = repository;
    }

    public List<Employee> Execute () {
        return repository.employeeList();
    }

}
namespace OMB.Aplication.EmployeeUseCases;

using OMB.Aplication.ClasesBase;
using OMB.Aplication.Interfaces;

public class employeeListUseCase {

    public readonly IEmployeeRepository repository;

    public employeeListUseCase (IEmployeeRepository repository) {
        this.repository = repository;
    }

    public List<Employee> Execute () {
        return repository.employeeList();
    }

}
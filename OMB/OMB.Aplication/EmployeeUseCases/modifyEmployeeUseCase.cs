namespace OMB.Aplication.EmployeeUseCases;

using OMB.Aplication.ClasesBase;
using OMB.Aplication.Interfaces;

public class modifyEmployeeUseCase {

    public readonly IEmployeeRepository repository;

    public modifyEmployeeUseCase (IEmployeeRepository repository) {
        this.repository = repository;
    }

    public void Execute (Employee employee) {
        repository.modifyEmployee(employee);
    }

}
namespace OMB.Aplication.EmployeeUseCases;

using OMB.Aplication.Interfaces;

public class deleteEmployeeUseCase {

    public readonly IEmployeeRepository repository;

    public deleteEmployeeUseCase (IEmployeeRepository repository) {
        this.repository = repository;
    }

    public void Execute (int id) {
        repository.deleteEmployee(id);
    }

}
namespace OMB.Aplication.UserUseCases;

using OMB.Aplication.ClasesBase;
using OMB.Aplication.Interfaces;

public class addUserUseCase {

    public readonly IUserRepository repository;

    public addUserUseCase (IUserRepository repository) {
        this.repository = repository;
    }

    public void Execute (User user) {
        repository.addUser(user);
    }

}
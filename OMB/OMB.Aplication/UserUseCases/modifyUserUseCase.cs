namespace OMB.Aplication.UserUseCases;

using OMB.Aplication.ClasesBase;
using OMB.Aplication.Interfaces;

public class modifyUserUseCase {

    public readonly IUserRepository repository;

    public modifyUserUseCase (IUserRepository repository) {
        this.repository = repository;
    }

    public void Execute (User user) {
        repository.modifyUser(user);
    }

}
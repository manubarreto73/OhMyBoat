namespace OMB.Aplication.UserUseCases;

using OMB.Aplication.Interfaces;

public class deleteUserUseCase {

    public readonly IUserRepository repository;

    public deleteUserUseCase (IUserRepository repository) {
        this.repository = repository;
    }

    public void Execute (string userName) {
        repository.deleteUser(userName);
    }

}
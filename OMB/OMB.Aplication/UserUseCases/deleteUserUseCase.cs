namespace OMB.Aplication.UserUseCases;

using OMB.Aplication.Interfaces.IUserRepository;

public class deleteUserUseCase {

    public readonly IUserRepository repository;

    public deleteUserUseCase (IUserRepository repository) {
        this.repository = repository;
    }

    public void Ejecutar (string username) {
        repository.deleteUser(username);
    }

}
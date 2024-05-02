namespace OMB.Aplication.UserUseCases;

using OMB.Aplication.ClasesBase.User;
using OMB.Aplication.Interfaces.IUserRepository;

public class addUserUseCase {

    public readonly IUserRepository repository;

    public addUserUseCase (IUserRepository repository) {
        this.repository = repository;
    }

    public void Ejecutar (User user) {
        repository.addUser(user);
    }

}
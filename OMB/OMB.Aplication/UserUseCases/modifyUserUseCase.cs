namespace OMB.Aplication.UserUseCases;

using OMB.Aplication.ClasesBase.User;
using OMB.Aplication.Interfaces.IUserRepository;

public class modifyUserUseCase {

    public readonly IUserRepository repository;

    public modifyUserUseCase (IUserRepository repository) {
        this.repository = repository;
    }

    public void Ejecutar (User user) {
        repository.modifyUser(user);
    }

}
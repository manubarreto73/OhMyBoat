namespace OMB.Aplication.UserUseCases;

using OMB.Aplication.ClasesBase.User;
using OMB.Aplication.Interfaces.IUserRepository;

public class userListUseCase {

    public readonly IUserRepository repository;

    public userListUseCase (IUserRepository repository) {
        this.repository = repository;
    }

    public List<User> Ejecutar () {
        return repository.userList();
    }

}
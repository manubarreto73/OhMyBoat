namespace OMB.Aplication.UserUseCases;

using OMB.Aplication.ClasesBase;
using OMB.Aplication.Interfaces;

public class userListUseCase {

    public readonly IUserRepository repository;

    public userListUseCase (IUserRepository repository) {
        this.repository = repository;
    }

    public List<User> Execute () {
        return repository.userList();
    }

}
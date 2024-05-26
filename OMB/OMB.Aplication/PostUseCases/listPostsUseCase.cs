namespace OMB.Aplication.PostUseCases;

using OMB.Aplication.ClasesBase;
using OMB.Aplication.Interfaces;

public class listPostUseCase {

    public readonly IPostRepository repository;

    public listPostUseCase (IPostRepository repository) {
        this.repository = repository;
    }

    public List<Post> Execute () {
        return repository.postList();
    }

}
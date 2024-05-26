namespace OMB.Aplication.PostUseCases;

using OMB.Aplication.ClasesBase;
using OMB.Aplication.Interfaces;

public class addPostUseCase {

    public readonly IPostRepository repository;

    public addPostUseCase (IPostRepository repository) {
        this.repository = repository;
    }

    public void Execute (Post post) {
        repository.addPost(post);
    }

}
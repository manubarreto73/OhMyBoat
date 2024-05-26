namespace OMB.Aplication.PostUseCases;

using OMB.Aplication.ClasesBase;
using OMB.Aplication.Interfaces;

public class modifyPostUseCase {

    public readonly IPostRepository repository;

    public modifyPostUseCase (IPostRepository repository) {
        this.repository = repository;
    }

    public void Execute (Post post) {
        repository.modifyPost(post);
    }

}
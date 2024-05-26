namespace OMB.Aplication.PostUseCases;

using OMB.Aplication.Interfaces;

public class deletePostUseCase {

    public readonly IPostRepository repository;

    public deletePostUseCase (IPostRepository repository) {
        this.repository = repository;
    }

    public void Execute (int postId) {
        repository.deletePost(postId);
    }

}
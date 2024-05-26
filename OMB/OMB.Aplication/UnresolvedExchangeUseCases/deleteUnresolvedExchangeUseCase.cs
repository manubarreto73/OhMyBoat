namespace OMB.Aplication.UnresolvedExchangeUseCases;

using OMB.Aplication.Interfaces;

public class deleteUnresolvedExchangeUseCase {

    public readonly IUnresolvedExchangeRepository repository;

    public deleteUnresolvedExchangeUseCase (IUnresolvedExchangeRepository repository) {
        this.repository = repository;
    }

    public void Execute (int id) {
        repository.deleteUnresolvedExchange(id);
    }

}
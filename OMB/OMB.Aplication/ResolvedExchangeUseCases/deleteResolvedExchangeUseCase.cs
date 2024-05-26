namespace OMB.Aplication.ResolvedExchangeUseCases;

using OMB.Aplication.Interfaces;

public class deleteResolvedExchangeUseCase {

    public readonly IResolvedExchangeRepository repository;

    public deleteResolvedExchangeUseCase (IResolvedExchangeRepository repository) {
        this.repository = repository;
    }

    public void Execute (int id) {
        repository.deleteResolvedExchange(id);
    }

}
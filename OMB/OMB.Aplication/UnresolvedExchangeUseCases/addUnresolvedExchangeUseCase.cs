namespace OMB.Aplication.UnresolvedExchangeUseCases;

using OMB.Aplication.ClasesBase;
using OMB.Aplication.Interfaces;

public class addUnresolvedExchangeUseCase {

    public readonly IUnresolvedExchangeRepository repository;

    public addUnresolvedExchangeUseCase (IUnresolvedExchangeRepository repository) {
        this.repository = repository;
    }

    public void Execute (UnresolvedExchange UnresolvedExchange) {
        repository.addUnresolvedExchange(UnresolvedExchange);
    }

}
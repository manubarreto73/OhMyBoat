namespace OMB.Aplication.UnresolvedExchangeUseCases;

using OMB.Aplication.ClasesBase;
using OMB.Aplication.Interfaces;

public class modifyUnresolvedExchangeUseCase {

    public readonly IUnresolvedExchangeRepository repository;

    public modifyUnresolvedExchangeUseCase (IUnresolvedExchangeRepository repository) {
        this.repository = repository;
    }

    public void Execute (UnresolvedExchange UnresolvedExchange) {
        repository.modifyUnresolvedExchange(UnresolvedExchange);
    }

}
namespace OMB.Aplication.ResolvedExchangeUseCases;

using OMB.Aplication.ClasesBase;
using OMB.Aplication.Interfaces;

public class addResolvedExchangeUseCase {

    public readonly IResolvedExchangeRepository repository;

    public addResolvedExchangeUseCase (IResolvedExchangeRepository repository) {
        this.repository = repository;
    }

    public void Execute (ResolvedExchange ResolvedExchange) {
        repository.addResolvedExchange(ResolvedExchange);
    }

}
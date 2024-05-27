namespace OMB.Aplication.ResolvedExchangeUseCases;

using OMB.Aplication.ClasesBase;
using OMB.Aplication.Interfaces;

public class modifyResolvedExchangeUseCase {

    public readonly IResolvedExchangeRepository repository;

    public modifyResolvedExchangeUseCase (IResolvedExchangeRepository repository) {
        this.repository = repository;
    }

    public void Execute (ResolvedExchange ResolvedExchange) {
        repository.modifyResolvedExchange(ResolvedExchange);
    }

}
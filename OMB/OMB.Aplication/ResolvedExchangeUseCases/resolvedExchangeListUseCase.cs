namespace OMB.Aplication.ResolvedExchangeUseCases;

using OMB.Aplication.ClasesBase;
using OMB.Aplication.Interfaces;

public class resolvedExchangeListUseCase {

    public readonly IResolvedExchangeRepository repository;

    public resolvedExchangeListUseCase (IResolvedExchangeRepository repository) {
        this.repository = repository;
    }

    public List<ResolvedExchange> Execute () {
        return repository.resolvedExchangeList();
    }

}
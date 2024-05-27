namespace OMB.Aplication.UnresolvedExchangeUseCases;

using OMB.Aplication.ClasesBase;
using OMB.Aplication.Interfaces;

public class unresolvedExchangeListUseCase {

    public readonly IUnresolvedExchangeRepository repository;

    public unresolvedExchangeListUseCase (IUnresolvedExchangeRepository repository) {
        this.repository = repository;
    }

    public List<UnresolvedExchange> Execute () {
        return repository.UnresolvedExchangeList();
    }

}
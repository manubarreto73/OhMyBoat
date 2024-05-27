namespace OMB.Aplication.TransportUseCases;

using OMB.Aplication.ClasesBase;
using OMB.Aplication.Interfaces;

public class addTransportUseCase {

    public readonly ITransportRepository repository;

    public addTransportUseCase (ITransportRepository repository) {
        this.repository = repository;
    }

    public void Execute (Transport transport) {
        repository.addTransport(transport);
    }

}
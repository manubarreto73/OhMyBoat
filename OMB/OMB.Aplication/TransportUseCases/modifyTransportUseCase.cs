namespace OMB.Aplication.TransportUseCases;

using OMB.Aplication.ClasesBase;
using OMB.Aplication.Interfaces;

public class modifyTransportUseCase {

    public readonly ITransportRepository repository;

    public modifyTransportUseCase (ITransportRepository repository) {
        this.repository = repository;
    }

    public void Execute (Transport Transport) {
        repository.modifyTransport(Transport);
    }

}
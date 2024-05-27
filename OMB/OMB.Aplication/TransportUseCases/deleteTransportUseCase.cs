namespace OMB.Aplication.TransportUseCases;

using OMB.Aplication.Interfaces;

public class deleteTransportUseCase {

    public readonly ITransportRepository repository;

    public deleteTransportUseCase (ITransportRepository repository) {
        this.repository = repository;
    }

    public void Execute (int transportId) {
        repository.deleteTransport(transportId);
    }

}
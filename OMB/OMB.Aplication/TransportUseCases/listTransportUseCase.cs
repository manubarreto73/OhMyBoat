namespace OMB.Aplication.TransportUseCases;

using OMB.Aplication.ClasesBase;
using OMB.Aplication.Interfaces;

public class listTransportUseCase {

    public readonly ITransportRepository repository;

    public listTransportUseCase (ITransportRepository repository) {
        this.repository = repository;
    }

    public List<Transport> Execute () {
        return repository.listTransports();
    }

}
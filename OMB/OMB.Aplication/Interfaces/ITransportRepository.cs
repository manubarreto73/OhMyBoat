namespace OMB.Aplication.Interfaces;

using OMB.Aplication.ClasesBase;

public interface ITransportRepository {

    public void addTransport(Transport transport);
    public void deleteTransport (int transportId);
    public List<Transport> listTransports();

}
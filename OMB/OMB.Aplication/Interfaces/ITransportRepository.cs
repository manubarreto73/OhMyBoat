namespace OMB.Aplication.Interfaces;

using OMB.Aplication.ClasesBase;

public interface ITransportRepository {

    public void addTransport(Transport transport);
    public void deleteTransport (int transportId);
    public void modifyTransport (Transport transport);
    public List<Transport> listTransports();

}
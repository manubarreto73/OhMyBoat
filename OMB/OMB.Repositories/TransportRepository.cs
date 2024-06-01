namespace OMB.Repositories;

using OMB.Aplication.ClasesBase;
using OMB.Aplication.Interfaces;
public class TransportRepository : ITransportRepository {

    public void deleteTransport (int transportId){
        using(OMBContext context = new OMBContext()){
            var exists = context.Transports.Where(t => t.Id == transportId).SingleOrDefault();
            if(exists != null){
                context.Remove(exists);
                context.SaveChanges();
            }
        }
    }

    public void addTransport (Transport transport){
        using(OMBContext context = new OMBContext()){
            var exists = context.Transports.Where(t => t.plate == transport.plate).SingleOrDefault();
            if(exists == null){
                context.Add((Transport)transport.Clone());
                context.SaveChanges();
            }
            else{
                throw new Exception("Placa ya registrada");
            }
        }
    }

    //SOLO MODIFICA EL OWNER
    public void modifyTransport (Transport transport){
        using(OMBContext context = new OMBContext()){
            var exists = context.Transports.Where(T => T.Id == transport.Id).SingleOrDefault();
            if(exists != null){
                exists.UserId = transport.UserId; 
                context.SaveChanges();
            }
        }
    }

    public List<Transport> listTransports(){
        List<Transport> aux = new List<Transport>();
        List<Transport> l;
        using(OMBContext context = new OMBContext()){
            l = context.Transports.ToList();
        }
        foreach (Transport t in l){
            aux.Add((Transport)t.Clone());
        }
        return aux;
    }
}
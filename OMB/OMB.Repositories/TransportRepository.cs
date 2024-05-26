namespace OMB.Repositories;

using OMB.Aplication.Interfaces;
public class TransportRepository : ITransportRepository { //implementar interfaz

    public void deleteTransport (int transportId){
        using(OMBContext context = new OMBContext()){
            var exists = context.Transports.Where(t => t.Id == transportId).SingleOrDefault();
            if(exists != null){
                context.Remove(exists);
                context.SaveChanges();
            }
        }
    }
}
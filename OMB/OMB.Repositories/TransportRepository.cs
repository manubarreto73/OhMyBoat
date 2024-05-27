namespace OMB.Repositories;

using OMB.Aplication.ClasesBase;
using OMB.Aplication.Interfaces;
public class TransportRepository : ITransportRepository {

    private IShipImageRepository SIR;
    private IVehicleImageRepository VIR;
    private IPostRepository PR;

    public TransportRepository(IShipImageRepository SIR, IVehicleImageRepository VIR, IPostRepository PR){
        this.SIR = SIR;
        this.VIR = VIR;
        this.PR = PR;
    }
    public void deleteTransport (int transportId){
        Transport? exists;
        using(OMBContext context = new OMBContext()){
            exists = context.Transports.Where(t => t.Id == transportId).SingleOrDefault();
        }
        if(exists != null){
            Post? post = PR.postList().Where(p => p.TransportId == transportId).SingleOrDefault();
            PR.deletePost((post == null) ? -1 : post.Id);
            List<VehicleImage> vm = VIR.listVehicleImages().Where(i => i.VehicleId == transportId).ToList();
            List<ShipImage> sm = SIR.listShipImages().Where(i => i.ShipId == transportId).ToList();
            foreach (VehicleImage i in vm){
                VIR.deleteVehicleImage(i.Id);
            }
            foreach (ShipImage i in sm){
                SIR.deleteShipImage(i.Id);
            }
            using(OMBContext context = new OMBContext()){
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
namespace OMB.Repositories;

using OMB.Aplication.Interfaces;
using OMB.Aplication.ClasesBase;
using Microsoft.EntityFrameworkCore;

public class ResolvedExchangeRepository : IResolvedExchangeRepository {
    
    private IVehicleHistoryRepository VHRep;
    private IShipHistoryRepository SHRep;

    public ResolvedExchangeRepository(IVehicleHistoryRepository VHRep, IShipHistoryRepository SHRep){
        this.VHRep = VHRep;
        this.SHRep = SHRep;
    }

    public void addResolvedExchange (ResolvedExchange resolvedExchange){
        using(OMBContext context = new OMBContext()){
            context.ResolvedExchanges.Add((ResolvedExchange)resolvedExchange.Clone());
            context.SaveChanges();
        }
    }

    //Incompleto -> no borra los transportes correspondientes
    public void deleteResolvedExchange (int resolvedExchangeId){
        using(OMBContext context = new OMBContext()){
            var exists = context.ResolvedExchanges.Where(U => U.Id == resolvedExchangeId).SingleOrDefault();
            if(exists != null){
                context.Remove(exists);
                context.SaveChanges();
            }
        }
    }

    public List<ResolvedExchange> resolvedExchangeList (){
        using(OMBContext context = new OMBContext()){
            List<ResolvedExchange> copia = new List<ResolvedExchange>();
            List<ResolvedExchange> original = context.ResolvedExchanges.Include(r => r.transporteOfertado).Include(r => r.transportePosteado).Include(r => r.sede).ToList();
            foreach (ResolvedExchange resolvedExchange in original)
                copia.Add((ResolvedExchange)resolvedExchange.Clone());
            return copia;
        }
    }

}
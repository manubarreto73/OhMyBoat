namespace OMB.Repositories;

using OMB.Aplication.Interfaces;
using OMB.Aplication.ClasesBase;
using Microsoft.EntityFrameworkCore;

public class UnresolvedExchangeRepository : IUnresolvedExchangeRepository {

    public void addUnresolvedExchange (UnresolvedExchange unresolvedExchange){
        using(OMBContext context = new OMBContext()){
            context.Add((UnresolvedExchange)unresolvedExchange.Clone());
            context.SaveChanges();
        }
    }
    public void deleteUnresolvedExchange (int unresolvedExchangeId){
        using(OMBContext context = new OMBContext()){
            var exists = context.UnresolvedExchanges.Where(U => U.Id == unresolvedExchangeId).SingleOrDefault();
            if(exists != null){
                context.Remove(exists);
                context.SaveChanges();
            }
        }
    }
    public void modifyUnresolvedExchange (UnresolvedExchange unresolvedExchange) {
        using(OMBContext context = new OMBContext()){
            var exists = context.UnresolvedExchanges.Where(U => U.Id == unresolvedExchange.Id).SingleOrDefault();
            if (exists != null) {
                exists.fechaYHora = unresolvedExchange.fechaYHora;
                exists.sedeId = unresolvedExchange.sedeId;
                exists.state = unresolvedExchange.state;
                context.SaveChanges();
            }
        }
    }

    public List<UnresolvedExchange> UnresolvedExchangeList (){
        using(OMBContext context = new OMBContext()){
            List<UnresolvedExchange> copia = new List<UnresolvedExchange>();
            List<UnresolvedExchange> original = context.UnresolvedExchanges.ToList();
            foreach (UnresolvedExchange unresolvedExchange in original)
                copia.Add((UnresolvedExchange)unresolvedExchange.Clone());
            return copia;
        }
    }
}
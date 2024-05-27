namespace OMB.Aplication.Interfaces;

using OMB.Aplication.ClasesBase;

public interface IResolvedExchangeRepository {

    public void addResolvedExchange (ResolvedExchange ResolvedExchange);
    public void deleteResolvedExchange (int ResolvedExchangeId);
    // public void modifyResolvedExchange (ResolvedExchange ResolvedExchange); 
    public List<ResolvedExchange> resolvedExchangeList ();

}
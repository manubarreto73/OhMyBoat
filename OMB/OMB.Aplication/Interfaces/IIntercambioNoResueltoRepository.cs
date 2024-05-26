namespace OMB.Aplication.Interfaces;

using OMB.Aplication.ClasesBase;

public interface IUnresolvedExchangeRepository {

    public void addUnresolvedExchange (UnresolvedExchange UnresolvedExchange);
    public void deleteUnresolvedExchange (int UnresolvedExchangeId);
    public void modifyUnresolvedExchange (UnresolvedExchange UnresolvedExchange); 
    public List<UnresolvedExchange> UnresolvedExchangeList ();

}
namespace OMB.Aplication.Interfaces;

using OMB.Aplication.ClasesBase;

public interface IOfferRepository {

    public void addOffer (Offer Offer);
    public void deleteOffer (int OfferId);
    public void modifyOffer (Offer Offer); 
    public List<Offer> offerList ();

}
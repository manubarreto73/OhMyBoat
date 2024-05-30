namespace OMB.Aplication.OfferUseCases;

using OMB.Aplication.ClasesBase;
using OMB.Aplication.Interfaces;

public class modifyOfferUseCase {

    public readonly IOfferRepository repository;

    public modifyOfferUseCase (IOfferRepository repository) {
        this.repository = repository;
    }

    public void Execute (Offer offer) {
        repository.modifyOffer(offer);
    }

}
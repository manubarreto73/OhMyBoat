namespace OMB.Aplication.OfferUseCases;

using OMB.Aplication.ClasesBase;
using OMB.Aplication.Interfaces;

public class addOfferUseCase {

    public readonly IOfferRepository repository;

    public addOfferUseCase (IOfferRepository repository) {
        this.repository = repository;
    }

    public void Execute (Offer offer) {
        repository.addOffer(offer);
    }

}
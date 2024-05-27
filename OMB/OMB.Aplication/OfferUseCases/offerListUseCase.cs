namespace OMB.Aplication.OfferUseCases;

using OMB.Aplication.ClasesBase;
using OMB.Aplication.Interfaces;

public class offerListUseCase {

    public readonly IOfferRepository repository;

    public offerListUseCase (IOfferRepository repository) {
        this.repository = repository;
    }

    public List<Offer> Execute () {
        return repository.offerList();
    }

}
namespace OMB.Aplication.OfferUseCases;

using OMB.Aplication.Interfaces;

public class deleteOfferUseCase {

    public readonly IOfferRepository repository;

    public deleteOfferUseCase (IOfferRepository repository) {
        this.repository = repository;
    }

    public void Execute (int id) {
        repository.deleteOffer(id);
    }

}
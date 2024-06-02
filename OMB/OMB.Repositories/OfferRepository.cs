namespace OMB.Repositories;

using OMB.Aplication.Interfaces;
using OMB.Aplication.ClasesBase;
using Microsoft.EntityFrameworkCore;

public class OfferRepository : IOfferRepository {

    public void addOffer (Offer offer){
        using(OMBContext context = new OMBContext()){
            // El único chequeo de repetidos, es que un user no oferte el mismo T al mismo T dos veces (si oferta, borra y oferta no hay drama)
            bool exists = (context.Offers.Where(O => O.transporteOfertadoId == offer.transporteOfertadoId && O.transportePosteadoId == offer.transportePosteadoId).SingleOrDefault() != null);
            if(!exists){
                context.Add((Offer)offer.Clone());
            }
            else{
                //De todas formas nunca se debería llegar a esto desde la UI
                throw new Exception("Ya ofertaste este transporte acá!");
            }
            context.SaveChanges();
        }
    }

    //para lo unico que se va a modificar una oferta es para el state
    public void modifyOffer (Offer offer) {
        using(OMBContext context = new OMBContext()) {
            var exists = context.Offers.Where(O => O.Id == offer.Id).SingleOrDefault();
            if (exists != null) {
                exists.state = offer.state;
                exists.transportePosteadoId = offer.transportePosteadoId;
            }
            context.SaveChanges();
        }
    }

    public void deleteOffer (int OfferId){
        using(OMBContext context = new OMBContext()){
            var exists = context.Offers.Where(U => U.Id == OfferId).SingleOrDefault();
            if(exists != null){
                context.Remove(exists);
                context.SaveChanges();
            }
        }
    }

    public List<Offer> offerList (){
        using(OMBContext context = new OMBContext()){
            List<Offer> copia = new List<Offer>();
            List<Offer> original = context.Offers.ToList();
            foreach (Offer offer in original)
                copia.Add((Offer)offer.Clone());
            return copia;
        }
    }
}
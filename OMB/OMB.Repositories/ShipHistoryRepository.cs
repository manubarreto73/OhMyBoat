namespace OMB.Repositories;

using OMB.Aplication.ClasesBase;
using OMB.Aplication.Interfaces;
using Microsoft.EntityFrameworkCore;

public class ShipHistoryRepository : IShipHistoryRepository {
    public void addShip (ShipHistory ship) {
        using(OMBContext context = new OMBContext()) {
            context.ShipsHistory.Add(ship);
            context.SaveChanges();
        }
    }

    public void deleteShip (int shipId) {
        using(OMBContext context = new OMBContext()) {
            var exists = context.ShipsHistory.Where(S => S.Id == shipId).SingleOrDefault();
            if(exists != null){
                context.ShipsHistory.Remove(exists);
                context.SaveChanges();
            }
        }
    }

    public void modifyShip (ShipHistory ship) {
        using(OMBContext context = new OMBContext()) {
            var exists = context.ShipsHistory.Where(S => S.Id == ship.Id).SingleOrDefault();
            if(exists != null) {
                exists.model = ship.model;
                exists.eslora = ship.eslora;
                exists.manga = ship.manga;
                exists.calado = ship.calado;
                exists.hasEngine = ship.hasEngine;
                exists.type = ship.type;
                exists.description = ship.description;
                exists.plate = ship.plate;
                context.SaveChanges();
            }
        }
    }

    public List<ShipHistory> shipList() {
        using(OMBContext context = new OMBContext()) {
            List<ShipHistory> copia = new List<ShipHistory>();
            List<ShipHistory> original = context.ShipsHistory.ToList();
            foreach (ShipHistory ship in original)
                copia.Add((ShipHistory)ship.Clone());
            return copia;
        }
    }
}
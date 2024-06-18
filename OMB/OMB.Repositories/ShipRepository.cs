namespace OMB.Repositories;

using OMB.Aplication.ClasesBase;
using OMB.Aplication.Interfaces;
using Microsoft.EntityFrameworkCore;

public class ShipRepository : IShipRepository {
    
    private IPostRepository SPRep;
    private IShipImageRepository SIRep;

    public ShipRepository(IPostRepository SPRep, IShipImageRepository SIRep) {
        this.SPRep = SPRep;
        this.SIRep = SIRep;
    }

    public void addShip (Ship ship) {
        using(OMBContext context = new OMBContext()) {
            var exists = context.Ships.Where(S => S.plate == ship.plate).SingleOrDefault();
            if(exists == null) {
                context.Ships.Add((Ship)ship.Clone());
                context.SaveChanges();
            }
            else {
                throw new Exception("Plate number already registered");
            }
        }
    }

    public void deleteShip (int shipId) {
        Post? p = null;
        using(OMBContext context = new OMBContext()) {
            var exists = context.Ships.Include(S => S.post).Where(S => S.Id == shipId).SingleOrDefault();
            if(exists != null) {
                p = exists.post;
            }
        }
        if(p != null)
            this.SPRep.deletePost(p.Id);

        List<ShipImage> images = new List<ShipImage>();
        using(OMBContext context = new OMBContext()){
            var exists = context.Ships.Include(S => S.ShipImages).Where(S => S.Id == shipId).SingleOrDefault();
            if(exists != null && exists.ShipImages != null){
                images = exists.ShipImages;
            }
        }
        foreach(ShipImage si in images) {
            this.SIRep.deleteShipImage(si.Id);
        }

        using(OMBContext context = new OMBContext()) {
            var exists = context.Ships.Where(S => S.Id == shipId).SingleOrDefault();
            if(exists != null){
                context.Ships.Remove(exists);
                context.SaveChanges();
            }
        }
    }

    public void modifyShip (Ship ship) {
        using(OMBContext context = new OMBContext()) {
            var exists = context.Ships.Where(S => S.Id == ship.Id).SingleOrDefault();
            Ship? aux = null;
            if(exists != null) {
                if(ship.plate != exists.plate) {
                    aux = context.Ships.Where(S => S.plate == ship.plate).SingleOrDefault();
                }
                if(aux == null) {
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
                else {
                    throw new Exception("This plate is already in our database");
                }
            }
        }
    }

    public List<Ship> shipList() {
        using(OMBContext context = new OMBContext()) {
            List<Ship> Ret = new List<Ship>();
            List<Ship> Ori = context.Ships.ToList();
            foreach (Ship ship in Ori)
                Ret.Add((Ship)ship.Clone());
            return Ret;
        }
    }
}

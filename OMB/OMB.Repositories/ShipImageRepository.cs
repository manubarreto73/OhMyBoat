using OMB.Aplication.ClasesBase;
using OMB.Aplication.Interfaces;

namespace OMB.Repositories;

public class ShipImageRepository : IShipImageRepository{
    public void addShipImage(int Id, byte[] img){
        using(OMBContext context = new OMBContext()){
            Ship? s = context.Ships.Where(sh => sh.Id == Id).SingleOrDefault();
            if(s != null){
                int i = context.ShipImages.Where(im => im.ShipId == Id).Count();
                if (i < 3){
                        context.Add(new ShipImage(Id, img));
                        context.SaveChanges();
                }
            }
        }
    }

    public void deleteShipImage(int ShipImageId) {
        using(OMBContext context = new OMBContext()){
            var exists = context.ShipImages.Where(SI => SI.Id == ShipImageId).SingleOrDefault();
            if(exists != null){
                context.Remove(exists);
            }
        }
    }

    public List<ShipImage> listShipImages(){
        using(OMBContext context = new OMBContext()){
            List<ShipImage> ret = new List<ShipImage>();
            List<ShipImage> ori = context.ShipImages.ToList();
            foreach(ShipImage s in ori){
                ret.Add(Clone(s));
            }
            return context.ShipImages.ToList();
        }
    }

    private ShipImage Clone(ShipImage sh){
        byte[] aux = new byte[sh.Image.Count()];
        for(int i = 0; i < sh.Image.Count(); i++){
            aux[i] = sh.Image[i];
        }
        return new ShipImage(sh.ShipId, aux){Id = sh.Id};
    }
}
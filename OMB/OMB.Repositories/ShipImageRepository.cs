using System.Drawing;
using OMB.Aplication.ClasesBase;

namespace OMB.Repositories;

public class ShipImageRepository{
    public void addShipImage(int Id, Image img){
        using(OMBContext context = new OMBContext()){
            Ship? s = context.Ships.Where(sh => sh.Id == Id).SingleOrDefault();
            if(s != null){
                int i = context.ShipImages.Where(im => im.ShipId == Id).Count();
                if (i < 3){
                    using(var ms = new MemoryStream()){
                        (new Bitmap(img)).Save(ms, img.RawFormat);
                        context.Add(new ShipImage(Id, ms.ToArray()));
                        context.SaveChanges();
                    }
                }
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
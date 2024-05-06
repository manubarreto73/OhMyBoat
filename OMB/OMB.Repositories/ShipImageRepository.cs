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

    public List<byte[]> listShipImages(){
        using(OMBContext context = new OMBContext()){
            List<byte[]> ret = new List<byte[]>();
            List<ShipImage> ori = context.ShipImages.ToList();
            foreach(ShipImage s in ori){
                ret.Add(Clone(s.Image));
            }
            return ret;
        }
    }

    private byte[] Clone(byte[] a){
        byte[] res = new byte[a.Count()];
        int fin = a.Count();
        for(int i = 0; i < fin; i++){
            res[i] = a[i];
        }
        return res;
    }
}
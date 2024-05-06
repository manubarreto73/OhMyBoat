using System.Drawing;
using OMB.Aplication.ClasesBase;

namespace OMB.Repositories;

public class VehicleImageRepository{
    public void addVehicleImage(int Id, Image img){
        using(OMBContext context = new OMBContext()){
            Vehicle? v = context.Vehicles.Where(ve => ve.Id == Id).SingleOrDefault();
            if(v != null){
                int i = context.VehicleImages.Where(im => im.VehicleId == Id).Count();
                if (i < 3){
                    using(var ms = new MemoryStream()){
                        (new Bitmap(img)).Save(ms, img.RawFormat);
                        context.Add(new VehicleImage(Id, ms.ToArray()));
                        context.SaveChanges();
                    }
                }
            }
        }
    }

    public List<byte[]> listVehicleImages(){
        using(OMBContext context = new OMBContext()){
            List<byte[]> ret = new List<byte[]>();
            List<VehicleImage> ori = context.VehicleImages.ToList();
            foreach(VehicleImage v in ori){
                ret.Add(Clone(v.Image));
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
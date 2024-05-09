using System.Drawing;
using OMB.Aplication.ClasesBase;
using OMB.Aplication.Interfaces;

namespace OMB.Repositories;

public class VehicleImageRepository : IVehicleImageRepository{
    public void addVehicleImage(int Id, byte[] img){
        using(OMBContext context = new OMBContext()){
            Vehicle? v = context.Vehicles.Where(ve => ve.Id == Id).SingleOrDefault();
            if(v != null){
                int i = context.VehicleImages.Where(im => im.VehicleId == Id).Count();
                if (i < 3){
                    context.Add(new VehicleImage(Id, img));
                    context.SaveChanges();
                }
            }
        }
    }

    public void deleteVehicleImage(int VehicleImageId) {
        using(OMBContext context = new OMBContext()){
            var exists = context.VehicleImages.Where(VI => VI.Id == VehicleImageId).SingleOrDefault();
            if(exists != null){
                context.Remove(exists);
            }
        }
    }

    public List<VehicleImage> listVehicleImages(){
        using(OMBContext context = new OMBContext()){
            List<VehicleImage> ret = new List<VehicleImage>();
            List<VehicleImage> ori = context.VehicleImages.ToList();
            foreach(VehicleImage v in ori){
                ret.Add(Clone(v));
            }
            return context.VehicleImages.ToList();
        }
    }

    private VehicleImage Clone(VehicleImage ve){
        byte[] aux = new byte[ve.Image.Count()];
        for(int i = 0; i < ve.Image.Count(); i++){
            aux[i] = ve.Image[i];
        }
        return new VehicleImage(ve.VehicleId, aux){Id = ve.Id};
    }
}
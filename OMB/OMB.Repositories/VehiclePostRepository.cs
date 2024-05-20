namespace OMB.Repositories;

using OMB.Aplication.ClasesBase;
using OMB.Aplication.Interfaces;

public class VehiclePostRepository : IVehiclePostRepository {
        public void addVehiclePost (VehiclePost vehiclePost){
        using(OMBContext context = new OMBContext()){
            var exists = context.VehiclePosts.Where(VP => VP.VehicleId == vehiclePost.VehicleId).SingleOrDefault();
            if(exists == null){
                context.Add(Clone(vehiclePost));
                context.SaveChanges();
            }
            else{
                throw new Exception("Vehicle already posted");
            }
        }
    }
    public void deleteVehiclePost (int vehiclePostId){
        using(OMBContext context = new OMBContext()){
            var exists = context.VehiclePosts.Where(VP => VP.Id == vehiclePostId).SingleOrDefault();
            if(exists != null){
                context.Remove(exists);
                context.SaveChanges();
            }
        }
    }
    public void modifyVehiclePost (VehiclePost vehiclePost){
        using(OMBContext context = new OMBContext()){
            var exists = context.VehiclePosts.Where(VP => VP.Id == vehiclePost.Id).SingleOrDefault();
            if(exists != null){
                exists.Title = vehiclePost.Title;
                context.SaveChanges();
            }
        }
    }

    public List<VehiclePost> VehiclePostList (){
        using(OMBContext context = new OMBContext()){
            List<VehiclePost> Ret = new List<VehiclePost>();
            List<VehiclePost> Ori = context.VehiclePosts.ToList();
            foreach (VehiclePost vehiclePost in Ori)
                Ret.Add(Clone(vehiclePost));
            return Ret;
        }
    }

    private VehiclePost Clone(VehiclePost vehiclePost){
        return new VehiclePost(vehiclePost.VehicleId, vehiclePost.Title){posted = vehiclePost.posted, Id = vehiclePost.Id};
    }
}
namespace OMB.Repositories;

using OMB.Aplication.ClasesBase;
using OMB.Aplication.Interfaces;

public class ShipPostRepository : IShipPostRepository {
        public void addShipPost (ShipPost shipPost){
        using(OMBContext context = new OMBContext()){
            var exists = context.ShipPosts.Where(SP => SP.ShipId == shipPost.ShipId).SingleOrDefault();
            if(exists == null){
                context.Add(Clone(shipPost));
                context.SaveChanges();
            }
            else{
                throw new Exception("Ship already posted");
            }
        }
    }
    public void deleteShipPost (int shipPostId){
        using(OMBContext context = new OMBContext()){
            var exists = context.ShipPosts.Where(SP => SP.Id == shipPostId).SingleOrDefault();
            if(exists != null){
                context.Remove(exists);
                context.SaveChanges();
            }
        }
    }
    public void modifyShipPost (ShipPost shipPost){
        using(OMBContext context = new OMBContext()){
            var exists = context.ShipPosts.Where(SP => SP.Id == shipPost.Id).SingleOrDefault();
            if(exists != null){
                exists.Title = shipPost.Title;
                context.SaveChanges();
            }
        }
    }

    public List<ShipPost> ShipPostList (){
        using(OMBContext context = new OMBContext()){
            List<ShipPost> Ret = new List<ShipPost>();
            List<ShipPost> Ori = context.ShipPosts.ToList();
            foreach (ShipPost shipPost in Ori)
                Ret.Add(Clone(shipPost));
            return Ret;
        }
    }

    private ShipPost Clone(ShipPost shipPost){
        return new ShipPost(shipPost.ShipId, shipPost.Title){posted = shipPost.posted, Id = shipPost.Id};
    }
}
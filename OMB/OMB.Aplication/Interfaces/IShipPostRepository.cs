namespace OMB.Aplication.Interfaces;

using OMB.Aplication.ClasesBase;

public interface IShipPostRepository {

    public void addShipPost (ShipPost shipPost);
    public void deleteShipPost (int ShipPostId);
    public void modifyShipPost (ShipPost shipPost); 
    public List<ShipPost> ShipPostList ();

}
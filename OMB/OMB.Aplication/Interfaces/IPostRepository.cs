namespace OMB.Aplication.Interfaces;

using OMB.Aplication.ClasesBase;

public interface IPostRepository {

    public void addPost (Post vehiclePost);
    public void deletePost (int postId);
    public void modifyPost (Post post); 
    public List<Post> postList ();

}
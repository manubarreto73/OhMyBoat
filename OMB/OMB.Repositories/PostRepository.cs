namespace OMB.Repositories;

using OMB.Aplication.ClasesBase;
using OMB.Aplication.Interfaces;

public class PostRepository : IPostRepository {
        public void addPost (Post post){
        using(OMBContext context = new OMBContext()){
            var exists = context.Posts.Where(P => P.TransportId == post.TransportId).SingleOrDefault();
            if(exists == null){
                context.Add(Clone(post));
                context.SaveChanges();
            }
            else{
                throw new Exception("Item already posted");
            }
        }
    }
    public void deletePost (int postId){
        using(OMBContext context = new OMBContext()){
            var exists = context.Posts.Where(P => P.Id == postId).SingleOrDefault();
            if(exists != null){
                context.Remove(exists);
                context.SaveChanges();
            }
        }
    }
    public void modifyPost (Post post){
        using(OMBContext context = new OMBContext()){
            var exists = context.Posts.Where(P => P.Id == post.Id).SingleOrDefault();
            if(exists != null){
                exists.Title = post.Title;
                exists.paused = post.paused;
                context.SaveChanges();
            }
        }
    }

    public List<Post> postList (){
        using(OMBContext context = new OMBContext()){
            List<Post> Ret = new List<Post>();
            List<Post> Ori = context.Posts.ToList();
            foreach (Post post in Ori)
                Ret.Add(Clone(post));
            return Ret;
        }
    }

    private Post Clone(Post post){
        return new Post(post.TransportId, post.Title){posted = post.posted, Id = post.Id, paused = post.paused};
    }
}
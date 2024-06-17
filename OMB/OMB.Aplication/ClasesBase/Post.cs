namespace OMB.Aplication.ClasesBase;

public class Post{

    public int Id {get; set;}
    public string Title {get; set;}
    public int TransportId {get; set;}
    public DateTime posted {get; set;}
    public Transport? posting {get; set;}
    public bool paused {get; set;}

    public Post(int TransportId, string Title){
        this.TransportId = TransportId;
        this.Title = Title;
        this.posted = DateTime.Now;
    }

    public Post() {
        this.TransportId = 0;
        this.Title = "";
        this.posted = DateTime.Now; 
    }
}
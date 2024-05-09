namespace OMB.Aplication.ClasesBase;

public class ShipPost : Post{
    public int Id {get; set;} //No sé si sirve de algo
    public string Title {get; set;}
    public int ShipId {get; set;}
    public DateTime posted {get; set;}

    public bool getType(){
        return true;
    }

    public string getTitle(){
        return this.Title;
    }

    public int getId(){
        return this.ShipId;
    }

    public ShipPost(int ShipId, string Title){
        this.ShipId = ShipId;
        this.Title = Title;
        this.posted = DateTime.Now; //Creo que esto está bien??
    }
}
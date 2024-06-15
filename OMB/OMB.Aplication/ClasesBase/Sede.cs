namespace OMB.Aplication.ClasesBase;

public class Sede {
    public int Id {get; set;}
    public string name {get; set;}
    public double latitude {get; set;}
    public double longitude {get; set;}

    public Sede(string name, double latitude, double longitude) {
      this.name = name;
      this.latitude = latitude;
      this.longitude = longitude;
    }

    public Sede() {}
}
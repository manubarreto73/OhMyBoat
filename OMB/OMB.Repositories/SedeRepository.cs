namespace OMB.Repositories;

using OMB.Aplication.ClasesBase;
using OMB.Aplication.Interfaces;

public class SedeRepository : ISedeRepository {
  public void addSede(Sede sede) {
    using(OMBContext context = new OMBContext()) {
      var exists = context.Sedes.Where(S => S.name == sede.name).SingleOrDefault();
      if (exists == null) {
        context.Add(Clone(sede));
        context.SaveChanges();
      }
      else{
        throw new Exception("Sede ya registrada");
      }
    }
  }
  public void deleteSede(int sedeId) {
    using(OMBContext context = new OMBContext()) {
      var exists = context.Sedes.Where(S => S.Id == sedeId).SingleOrDefault();
      if (exists != null) {
        exists.isActive = false;
        context.SaveChanges();
      }
    }
  }
  public void modifySede(Sede sede) {
    using(OMBContext context = new OMBContext()) {
      var exists = context.Sedes.Where(S => S.Id == sede.Id).SingleOrDefault();
      Sede? aux = null;
      if (exists != null) {
        if(sede.name != exists.name) {
          aux = context.Sedes.Where(S => S.name == sede.name).SingleOrDefault();
        }
        if (aux == null) {
          exists.name = sede.name;
          exists.longitude = sede.longitude;
          exists.latitude = sede.latitude;
          exists.isActive = sede.isActive;
          context.SaveChanges();
        } else {
          throw new Exception("Sede ya registrada");
        }
      }
    }
  }

  public List<Sede> sedeList() {
    using(OMBContext context = new OMBContext()) {
      List<Sede> Ret = new List<Sede>();
      List<Sede> Ori = context.Sedes.ToList();
      foreach (Sede sede in Ori)
        Ret.Add(Clone(sede));
      return Ret;
    }
  }

  private Sede Clone(Sede sede){
    return new Sede(sede.name, sede.latitude, sede.longitude){Id = sede.Id, isActive = sede.isActive};
  }
}
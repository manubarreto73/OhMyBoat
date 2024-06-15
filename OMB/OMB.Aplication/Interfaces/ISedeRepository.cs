namespace OMB.Aplication.Interfaces;

using OMB.Aplication.ClasesBase;

public interface ISedeRepository {

    public void addSede (Sede sede);
    public void deleteSede (int sedeId);
    public void modifySede (Sede sede); 
    public List<Sede> sedeList ();

}
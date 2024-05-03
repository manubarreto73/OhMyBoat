namespace OMB.Aplication.Interfaces;

using OMB.Aplication.ClasesBase;

public interface IUserRepository {

    public void addUser (User user);
    public void deleteUser (int userId);
    public void modifyUser (User user); 
    //Vamos a usar esto para el changePassword? 
    //Es una tabla, creo que lo mejor es definir estas interfaces basicas y las cosas complejas resolverlas desde el front
    public List<User> userList ();

}
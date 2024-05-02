namespace OMB.Aplication.Interfaces.IUserRepository;

using OMB.Aplication.ClasesBase.User;

public interface IUserRepository {

    public void addUser (User user);
    public void deleteUser (string username);
    public void modifyUser (User user); 
    //Vamos a usar esto para el changePassword? 
    //Es una tabla, creo que lo mejor es definir estas interfaces basicas y las cosas complejas resolverlas desde el front
    public List<User> userList ();

}
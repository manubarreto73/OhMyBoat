namespace OMB.Aplication.Interfaces;

using OMB.Aplication.ClasesBase;

public interface IUserRepository {

    public void addUser (User user);
    public void deleteUser (int userId);
    public void modifyUser (User user); 
    public List<User> userList ();

}
namespace OMB.Repositories;

using OMB.Aplication.Interfaces;
using OMB.Aplication.ClasesBase;
using Microsoft.EntityFrameworkCore;

public class UserRepository : IUserRepository {
    
    private IShipRepository SRep;
    private IVehicleRepository VRep;

    public UserRepository(IShipRepository SRep, IVehicleRepository VRep){
        this.SRep = SRep;
        this.VRep = VRep;
    }

    public void addUser (User user){
        using(OMBContext context = new OMBContext()){
            var exists = context.Users.Where(U => U.userName == user.userName).SingleOrDefault();
            if(exists == null){
                exists = context.Users.Where(U => U.mail == user.mail).SingleOrDefault();
                if(exists == null){
                    context.Add(Clone(user));
                }
                else{
                    throw new Exception("Mail already in use!");
                }
            }
            else{
                throw new Exception("This username's already taken!");
            }
            context.SaveChanges();
        }
    }
    public void deleteUser (int userId){
        List<Ship> ships = new List<Ship>();
        List<Vehicle> vehicles = new List<Vehicle>();
        using(OMBContext context = new OMBContext()){
            var exists = context.Users.Include(U => U.Ships).Include(U => U.Vehicles).Where(U => U.Id == userId).SingleOrDefault();
            if(exists != null){
                ships = exists.Ships;
                vehicles = exists.Vehicles;
            }
        }
        foreach(Ship s in ships){
            this.SRep.deleteShip(s.Id);
        }
        foreach(Vehicle v in vehicles){
            this.VRep.deleteVehicle(v.Id);
        }
        using(OMBContext context = new OMBContext()){
            var exists = context.Users.Where(U => U.Id == userId).SingleOrDefault();
            if(exists != null){
                context.Remove(exists);
            }
        }
    }
    public void modifyUser (User user){
        using(OMBContext context = new OMBContext()){
            var exists = context.Users.Where(U => U.Id == user.Id).SingleOrDefault();
            var aux = context.Users.Where(U => U.userName == user.userName).SingleOrDefault();
            if(exists != null){
                if(aux == null){
                    aux = context.Users.Where(U => U.mail == user.mail).SingleOrDefault();
                    if(aux == null){
                        exists.mail = user.mail;
                        exists.name = user.name;
                        exists.surname = user.surname;
                        exists.number = user.number;
                        exists.userName = user.userName;
                        exists.birthDate = user.birthDate;
                        exists.password = user.password;
                        exists.banned = user.banned;
                        context.SaveChanges();
                    }
                    else{
                        throw new Exception("This mail is already in use");
                    }
                }
                else{
                    throw new Exception("This username is taken");
                }
            }
        }
    }

    public List<User> userList (){
        using(OMBContext context = new OMBContext()){
            List<User> Ret = new List<User>();
            List<User> Ori = context.Users.ToList();
            foreach (User user in Ori)
                Ret.Add(Clone(user));
            return Ret;
        }
    }

    private User Clone(User user){
        return new User(user.name, user.surname, user.userName, user.password, user.mail, user.number, user.birthDate){Id = user.Id, banned = user.banned};
    }
}

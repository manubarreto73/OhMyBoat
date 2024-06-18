namespace OMB.Repositories;

using OMB.Aplication.Interfaces;
using OMB.Aplication.ClasesBase;
using Microsoft.EntityFrameworkCore;

public class UserRepository : IUserRepository {
    
    private ITransportRepository TRep;

    public UserRepository(ITransportRepository TRep){
        this.TRep = TRep;
    }

    public void addUser (User user){
        using(OMBContext context = new OMBContext()){
            bool exists = (context.Users.Where(U => U.userName == user.userName).SingleOrDefault() != null) || (context.Employees.Where(E => E.userName == user.userName).SingleOrDefault() != null);
            if(!exists){
                exists = (context.Users.Where(U => U.mail == user.mail).SingleOrDefault() != null) || (context.Employees.Where(E => E.mail == user.mail).SingleOrDefault() != null);
                if(!exists){
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
        List<Transport> transports = new List<Transport>();
        using(OMBContext context = new OMBContext()){
            var exists = context.Users.Include(U => U.Transports).Where(U => U.Id == userId).SingleOrDefault();
            if(exists != null && exists.Transports != null){
                transports = exists.Transports;
            }
        }
        foreach(Transport t in transports){
            this.TRep.deleteTransport(t.Id);
        }
        using(OMBContext context = new OMBContext()){
            var exists = context.Users.Where(U => U.Id == userId).SingleOrDefault();
            if(exists != null){
                context.Remove(exists);
                context.SaveChanges();
            }
        }
    }
    public void modifyUser (User user){
        using(OMBContext context = new OMBContext()){
            var exists = context.Users.Where(U => U.Id == user.Id).SingleOrDefault();
            bool aux = false;
            if(exists != null){
                if(exists.userName != user.userName){
                    aux = (context.Users.Where(U => U.userName == user.userName).SingleOrDefault() != null) || (context.Employees.Where(E => E.userName == user.userName).SingleOrDefault() != null);
                }
                if(!aux){
                    if(exists.mail != user.mail){
                        aux = (context.Users.Where(U => U.mail == user.mail).SingleOrDefault() != null) || (context.Employees.Where(E => E.userName == user.userName).SingleOrDefault() != null);
                    }
                    if(!aux){
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

using pending_webAPI.Contexts;
using pending_webAPI.Domains;
using pending_webAPI.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pending_webAPI.Repositories
{
    public class User_Repository : IUser_Repository
    {

        pendingContext ctx = new pendingContext();
        public User Login(string email, string password)
        {
            return ctx.Users.FirstOrDefault(u => u.EmailUser == email && u.PasswordUser == password);
        }

        public void Register(User newUser)
        {
            ctx.Users.Add(newUser);

            ctx.SaveChanges();
        }

        public void Refresh(int idUser, User userRefresh)
        {
            User SearchedUser = ListId(idUser);

            if (SearchedUser != null)
            {
                SearchedUser.EmailUser = userRefresh.EmailUser;
                SearchedUser.PasswordUser = userRefresh.PasswordUser;
               
            }

            ctx.Users.Update(SearchedUser);

            ctx.SaveChanges();
        }

        public void Delete(int idUser)
        {
            User SearchedUser = ListId(idUser);

            ctx.Users.Remove(SearchedUser);

            ctx.SaveChanges();
        }

        public List<User> List()
        {
            return ctx.Users.ToList();
        }


        public User ListId(int id)
        {
            return ctx.Users.FirstOrDefault(c => c.IdUser == id);
        }
    }
}

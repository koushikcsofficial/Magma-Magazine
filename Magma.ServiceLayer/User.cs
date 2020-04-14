using Magma.DataAccessLayer;
using Magma.DomainModels;
using Magma.ServiceContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magma.ServiceLayer
{
    public class User : IUser
    {
        DatabaseContext db;
        public User()
        {
            this.db = new DatabaseContext();
        }

        public void insertUserAccount(UserAccount ua)
        {
            db.UserAccounts.Add(ua);
            db.SaveChanges();
        }

        public async void insertUserAccountAsync(UserAccount ua)
        {
            db.UserAccounts.Add(ua);
            await db.SaveChangesAsync();
        }

        public void insertUserDetails(UserDetail ud)
        {
            db.UserDetails.Add(ud);
            db.SaveChanges();
        }

        public async void insertUserDetailsAsync(UserDetail ud)
        {
            db.UserDetails.Add(ud);
            await db.SaveChangesAsync();
        }

        public void updateUserAccount(UserAccount ua)
        {
            UserAccount existingUA = db.UserAccounts.Where(temp => temp.User_Id == ua.User_Id).FirstOrDefault();
            existingUA.User_Password = ua.User_Password;

        }

        public void updateUserAccountAsync(UserAccount ua)
        {
            throw new NotImplementedException();
        }

        public void updateUserDetails(UserDetail ud)
        {
            throw new NotImplementedException();
        }

        public void updateUserDetailsAsync(UserDetail ud)
        {
            throw new NotImplementedException();
        }
    }
}

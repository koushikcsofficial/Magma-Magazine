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

        public void updateUserPassword(UserAccount ua)
        {
            UserAccount existingUA = db.UserAccounts.Where(temp => temp.User_Id == ua.User_Id).FirstOrDefault();
            existingUA.User_Password = ua.User_Password;
            existingUA.User_AccountUpdatedAt = ua.User_AccountUpdatedAt;
            existingUA.User_UpdatedFrom = ua.User_UpdatedFrom;
            db.SaveChanges();
        }

        public async void updateUserPasswordAsync(UserAccount ua)
        {
            UserAccount existingUA = db.UserAccounts.Where(temp => temp.User_Id == ua.User_Id).FirstOrDefault();
            existingUA.User_Password = ua.User_Password;
            existingUA.User_AccountUpdatedAt = ua.User_AccountUpdatedAt;
            existingUA.User_UpdatedFrom = ua.User_UpdatedFrom;
            await db.SaveChangesAsync();
        }

        public void updateUserDetails(UserDetail ud)
        {
            UserDetail existingUd = db.UserDetails.Where(temp => temp.User_Id == ud.User_Id).FirstOrDefault();
            existingUd.User_FirstName = ud.User_FirstName;
            existingUd.User_LastName = ud.User_LastName;
            existingUd.User_Age = ud.User_Age;
            existingUd.User_Mobile = ud.User_Mobile;
            existingUd.User_Gender = ud.User_Gender;
            existingUd.User_Avatar = ud.User_Avatar;
            db.SaveChanges();
        }

        public async void updateUserDetailsAsync(UserDetail ud)
        {
            UserDetail existingUd = db.UserDetails.Where(temp => temp.User_Id == ud.User_Id).FirstOrDefault();
            existingUd.User_FirstName = ud.User_FirstName;
            existingUd.User_LastName = ud.User_LastName;
            existingUd.User_Age = ud.User_Age;
            existingUd.User_Mobile = ud.User_Mobile;
            existingUd.User_Gender = ud.User_Gender;
            existingUd.User_Avatar = ud.User_Avatar;
            await db.SaveChangesAsync();
        }
    }
}

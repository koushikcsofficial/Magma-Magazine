using Magma.DataAccessLayer;
using Magma.DomainModels;
using Magma.ServiceContracts;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magma.ServiceLayer
{
    public class User : IUser
    {
        private static TimeZoneInfo INDIAN_ZONE = TimeZoneInfo.FindSystemTimeZoneById("India Standard Time");
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

        public async Task<bool> IsLoginValidAsync(string User_Email, string User_Password)
        {
            bool IsValid = await db.UserAccounts.AnyAsync(x => x.User_Email == User_Email.ToLower() && x.User_Password == User_Password && x.User_IsActive == 1);
            return IsValid;
        }

        public bool IsLoginValid(string User_Email, string User_Password)
        {
            bool IsValid = db.UserAccounts.Any(x => x.User_Email == User_Email.ToLower() && x.User_Password == User_Password && x.User_IsActive == 1);
            return IsValid;
        }

        public async Task<bool> IsEmailExistsAsync(string User_Email)
        {
            bool IsValid = await db.UserAccounts.AnyAsync(x => x.User_Email == User_Email.ToLower());
            return IsValid;
        }

        public bool IsEmailExists(string User_Email)
        {
            bool IsValid = db.UserAccounts.Any(x => x.User_Email == User_Email.ToLower());
            return IsValid;
        }

        public async Task<int> getAccountIdByEmailAsync(string User_Email)
        {
            var result = await (db.UserAccounts.Where(temp => temp.User_Email == User_Email.ToLower()).SingleOrDefaultAsync());
            return result.User_Id;
        }

        public int getAccountIdByEmail(string User_Email)
        {
            var result = db.UserAccounts.Where(temp => temp.User_Email == User_Email.ToLower()).SingleOrDefault();
            return result.User_Id;
        }

        public void registerUserLog(UserLog ul)
        {
            db.UserLogs.Add(ul);
            db.SaveChanges();
        }

        public async void registerUserLogAsync(UserLog ul)
        {
            db.UserLogs.Add(ul);
            await db.SaveChangesAsync();
        }

        public void finishUserLog(UserLog ul)
        {
            UserLog existingLog = db.UserLogs.Where(temp => (temp.Id==ul.Id)).SingleOrDefault();
            existingLog.User_LogoutTime = ul.User_LogoutTime;
            db.SaveChanges();
        }

        public async void finishUserLogAsync(UserLog ul)
        {
            UserLog existingLog = await (db.UserLogs.Where(temp => temp.Id == ul.Id).SingleOrDefaultAsync());
            existingLog.User_LogoutTime = ul.User_LogoutTime;
            await db.SaveChangesAsync();
        }

        public void insertUserRole(UserRoleMaster urm)
        {
            db.UserRoleMasters.Add(urm);
            db.SaveChanges();
        }

        public async void insertUserRoleAsync(UserRoleMaster urm)
        {
            db.UserRoleMasters.Add(urm);
            await db.SaveChangesAsync();
        }

        public UserAccount getUserAccountById(int User_Id)
        {
            return db.UserAccounts.Where(temp => temp.User_Id == User_Id).SingleOrDefault();
        }

        public async Task<UserAccount> getUserAccountByIdAsync(int User_Id)
        {
            return await db.UserAccounts.Where(temp => temp.User_Id == User_Id).SingleOrDefaultAsync();
        }

        public UserDetail getUserDetailByUserId(int User_Id)
        {
            return db.UserDetails.Where(temp => temp.User_Id == User_Id).SingleOrDefault();
        }

        public async Task<UserDetail> getUserDetailByUserIdAsync(int User_Id)
        {
            return await db.UserDetails.Where(temp => temp.User_Id == User_Id).SingleOrDefaultAsync();
        }

        public int getUserLogId(string IP)
        {
            var result = db.UserLogs.Where(temp => temp.User_LoginFrom == IP).OrderByDescending(d => d.User_LoginTime).FirstOrDefault();
            return result.Id;
        }

        public async Task<int> getUserLogIdAsync(string IP)
        {
            var result = await(db.UserLogs.Where(temp => temp.User_LoginFrom == IP).OrderByDescending(d => d.User_LoginTime).FirstOrDefaultAsync());
            return result.Id;
        }

        public int getRoleIdByName(string Role_Name)
        {
            var result = db.UserRoles.Where(temp => temp.Role_Name == Role_Name).SingleOrDefault();
            return result.Role_Id;
        }

        public async Task<int> getRoleIdByNameAsync(string Role_Name)
        {
            var result = await (db.UserRoles.Where(temp => temp.Role_Name == Role_Name).SingleOrDefaultAsync());
            return result.Role_Id;
        }

        public DateTime currentTimeIST()
        {
            DateTime indianTime = TimeZoneInfo.ConvertTimeFromUtc(DateTime.UtcNow, INDIAN_ZONE);
            return indianTime;
        }
    }
}

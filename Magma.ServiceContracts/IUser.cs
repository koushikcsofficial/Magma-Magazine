using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Magma.DomainModels;

namespace Magma.ServiceContracts
{
    public interface IUser
    {
        void insertUserAccount(UserAccount ua);
        void insertUserAccountAsync(UserAccount ua);

        void insertUserDetails(UserDetail ud);
        void insertUserDetailsAsync(UserDetail ud);

        void insertContent(Content content);
        void insertContentAsync(Content content);

        void insertUserRoleMaster(UserRoleMaster urm);
        void insertUserRoleMasterAsync(UserRoleMaster urm);

        void registerUserLog(UserLog ul);
        void registerUserLogAsync(UserLog ul);

        void finishUserLog(UserLog ul);
        void finishUserLogAsync(UserLog ul);

        void updateUserPassword(UserAccount ua);
        void updateUserPasswordAsync(UserAccount ua);

        void updateUserDetails(UserDetail ud);
        void updateUserDetailsAsync(UserDetail ud);

        UserAccount getUserAccountById(int User_Id);
        Task<UserAccount> getUserAccountByIdAsync(int User_Id);

        UserDetail getUserDetailByUserId(int User_Id);
        Task<UserDetail> getUserDetailByUserIdAsync(int User_Id);

        Task<int> getAccountIdByEmailAsync(string User_Email);
        int getAccountIdByEmail(string User_Email);

        int getUserLogId(string IP);
        Task<int> getUserLogIdAsync(string IP);

        int getUserAvatarId(int UserId, string IP);
        Task<int> getUserAvatarIdAsync(int UserId, string IP);

        int getRoleIdByName(string Role_Name);
        Task<int> getRoleIdByNameAsync(string Role_Name);
    }
}

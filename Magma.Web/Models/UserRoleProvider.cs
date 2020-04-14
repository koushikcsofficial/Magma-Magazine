using Magma.DataAccessLayer;
using System;
using System.Linq;
using System.Web.Security;

namespace Magma.Web.Models
{
    public class UserRoleProvider : RoleProvider
    {
        public override string ApplicationName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override void AddUsersToRoles(string[] usernames, string[] roleNames)
        {
            throw new NotImplementedException();
        }

        public override void CreateRole(string roleName)
        {
            throw new NotImplementedException();
        }

        public override bool DeleteRole(string roleName, bool throwOnPopulatedRole)
        {
            throw new NotImplementedException();
        }

        public override string[] FindUsersInRole(string roleName, string usernameToMatch)
        {
            throw new NotImplementedException();
        }

        public override string[] GetAllRoles()
        {
            throw new NotImplementedException();
        }

        public override string[] GetRolesForUser(string User_Email)
        {
            using (var context = new DatabaseContext())
            {
                var res = (from UserAccount in context.UserAccounts
                           join UserRoleMaster in context.UserRoleMasters on UserAccount.User_Id equals UserRoleMaster.User_Id
                           join UserRole in context.UserRoles on UserRoleMaster.Role_Id equals UserRole.Role_Id
                           where UserAccount.User_Email == User_Email
                           select UserRole.Role_Name).ToArray();
                return res;
            }
        }

        public override string[] GetUsersInRole(string roleName)
        {
            throw new NotImplementedException();
        }

        public override bool IsUserInRole(string username, string roleName)
        {
            throw new NotImplementedException();
        }

        public override void RemoveUsersFromRoles(string[] usernames, string[] roleNames)
        {
            throw new NotImplementedException();
        }

        public override bool RoleExists(string roleName)
        {
            throw new NotImplementedException();
        }
    }
}
using Magma.DataAccessLayer;
using Magma.DomainModels;
using Magma.ServiceContracts;
using System;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace Magma.ServiceLayer
{
    public class Author : IAuthor
    {
        private static TimeZoneInfo INDIAN_ZONE = TimeZoneInfo.FindSystemTimeZoneById("India Standard Time");
        DatabaseContext db;
        public Author()
        {
            this.db = new DatabaseContext();
        }
        public bool IsAuthorById(int? Id)
        {
            if (Id == null)
            {
                return false;
            }
            else
            {
                string roleName = "Admin";
                var role = db.UserRoles.Where(x => x.Role_Name == roleName).SingleOrDefault();
                return db.UserRoleMasters.Any(x => (x.User_Id == Id) && (x.Role_Id == role.Role_Id));
            }
        }
    }
}

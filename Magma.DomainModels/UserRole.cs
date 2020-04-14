using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Magma.DomainModels
{
    public class UserRole
    {
        
        public UserRole()
        {
            this.UserRoleMasters = new HashSet<UserRoleMaster>();
        }

        [Key]
        public int Role_Id { get; set; }
        public string Role_Name { get; set; }

        
        public virtual ICollection<UserRoleMaster> UserRoleMasters { get; set; }
    }
}

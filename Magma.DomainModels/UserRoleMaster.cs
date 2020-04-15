using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Magma.DomainModels
{
    [Table("UserRoleMaster")]
    public class UserRoleMaster
    {
        public int Id { get; set; }

        public int User_Id { get; set; }

        public int Role_Id { get; set; }

        public virtual UserAccount UserAccount { get; set; }

        public virtual UserRole UserRole { get; set; }
    }
}
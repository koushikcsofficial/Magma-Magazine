using System.ComponentModel.DataAnnotations;

namespace Magma.DomainModels
{
    public class UserRoleMaster
    {
        [Key]
        public int Id { get; set; }
        public int User_Id { get; set; }
        public int Role_Id { get; set; }

        public virtual UserAccount UserAccount { get; set; }
        public virtual UserRole UserRole { get; set; }
    }
}
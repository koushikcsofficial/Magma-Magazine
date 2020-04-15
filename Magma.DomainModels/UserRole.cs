using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Magma.DomainModels
{
    public class UserRole
    {

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public UserRole()
        {
            UserRoleMasters = new HashSet<UserRoleMaster>();
        }

        [Key]
        public int Role_Id { get; set; }

        [Required]
        [StringLength(20)]
        public string Role_Name { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserRoleMaster> UserRoleMasters { get; set; }
    }
}

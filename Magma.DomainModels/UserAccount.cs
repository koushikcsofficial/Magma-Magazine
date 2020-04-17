using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Magma.DomainModels
{
    public class UserAccount
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public UserAccount()
        {
            BlogComments = new HashSet<BlogComment>();
            BlogReactions = new HashSet<BlogReaction>();
            BlogsMasters = new HashSet<BlogsMaster>();
            Contents = new HashSet<Content>();
            Subscriptions = new HashSet<Subscription>();
            Subscriptions1 = new HashSet<Subscription>();
            UserLogs = new HashSet<UserLog>();
            UserRoleMasters = new HashSet<UserRoleMaster>();
        }

        [Key]
        public int User_Id { get; set; }

        [Required]
        [StringLength(255)]
        public string User_Email { get; set; }

        [Required]
        public string User_Password { get; set; }

        public byte User_IsActive { get; set; }

        public DateTime User_AccountCreatedAt { get; set; }

        public byte User_IsEmailVerified { get; set; }

        [Required]
        [StringLength(50)]
        public string User_AccountCreatedFrom { get; set; }

        public DateTime? User_AccountDeactiveAt { get; set; }

        public DateTime? User_AccountUpdatedAt { get; set; }

        [StringLength(50)]
        public string User_UpdatedFrom { get; set; }

        [StringLength(50)]
        public string User_DeactiveFrom { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BlogComment> BlogComments { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BlogReaction> BlogReactions { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BlogsMaster> BlogsMasters { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Content> Contents { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Subscription> Subscriptions { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Subscription> Subscriptions1 { get; set; }

        public virtual UserDetail UserDetail { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserLog> UserLogs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserRoleMaster> UserRoleMasters { get; set; }
    }
}

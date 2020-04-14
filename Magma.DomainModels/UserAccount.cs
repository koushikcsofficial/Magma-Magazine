using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Magma.DomainModels
{
    public class UserAccount
    {
        public UserAccount()
        {
            this.BlogComments = new HashSet<BlogComment>();
            this.BlogReactionsMasters = new HashSet<BlogReactionsMaster>();
            this.BlogsMasters = new HashSet<BlogsMaster>();
            this.Subscriptions = new HashSet<Subscription>();
            this.Subscriptions1 = new HashSet<Subscription>();
            this.UserLogs = new HashSet<UserLog>();
            this.UserRoleMasters = new HashSet<UserRoleMaster>();
        }

        [Key]
        public int User_Id { get; set; }
        public string User_Email { get; set; }
        public string User_Password { get; set; }
        public byte User_IsActive { get; set; }
        public DateTime User_AccountCreatedAt { get; set; }
        public byte User_IsEmailVerified { get; set; }
        public string User_AccountCreatedFrom { get; set; }
        public DateTime? User_AccountDeactiveAt { get; set; }
        public DateTime? User_AccountUpdatedAt { get; set; }
        public string User_UpdatedFrom { get; set; }
        public string User_DeactiveFrom { get; set; }


        public virtual ICollection<BlogComment> BlogComments { get; set; }

        public virtual ICollection<BlogReactionsMaster> BlogReactionsMasters { get; set; }

        public virtual ICollection<BlogsMaster> BlogsMasters { get; set; }

        public virtual ICollection<Subscription> Subscriptions { get; set; }

        public virtual ICollection<Subscription> Subscriptions1 { get; set; }
        public virtual UserDetail UserDetail { get; set; }

        public virtual ICollection<UserLog> UserLogs { get; set; }

        public virtual ICollection<UserRoleMaster> UserRoleMasters { get; set; }
    }
}

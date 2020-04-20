namespace Magma.DomainModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class Subscription
    {
        [Key]
        public int Subscription_Id { get; set; }

        public int User_Id { get; set; }

        public int Author_Id { get; set; }

        public DateTime Subscribed_at { get; set; }

        public virtual UserAccount UserAccount { get; set; }

        public virtual UserAccount UserAccount1 { get; set; }
    }
}

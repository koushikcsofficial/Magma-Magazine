using System;
using System.ComponentModel.DataAnnotations;

namespace Magma.DomainModels
{
    public class Subscription
    {
        [Key]
        public int Subscription_Id { get; set; }

        public int User_Id { get; set; }

        public int Author_Id { get; set; }

        public DateTime Subscribed_at { get; set; }

        public virtual UserAccount UserAccount { get; set; }

        public virtual UserAccount UserAccount1 { get; set; }
    }
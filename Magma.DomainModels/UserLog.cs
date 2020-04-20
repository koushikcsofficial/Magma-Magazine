namespace Magma.DomainModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class UserLog
    {
        public int Id { get; set; }

        public int User_Id { get; set; }

        public DateTime? User_LoginTime { get; set; }

        public DateTime? User_LogoutTime { get; set; }

        [Required]
        [StringLength(50)]
        public string User_LoginFrom { get; set; }

        public virtual UserAccount UserAccount { get; set; }
    }
}

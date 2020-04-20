namespace Magma.DomainModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("UserRoleMaster")]
    public partial class UserRoleMaster
    {
        public int Id { get; set; }

        public int User_Id { get; set; }

        public int Role_Id { get; set; }

        public virtual UserAccount UserAccount { get; set; }

        public virtual UserRole UserRole { get; set; }
    }
}

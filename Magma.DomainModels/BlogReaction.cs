namespace Magma.DomainModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class BlogReaction
    {
        public int Id { get; set; }

        public int Blog_Id { get; set; }

        public int Reaction_Id { get; set; }

        public int User_Id { get; set; }

        public virtual Blog Blog { get; set; }

        public virtual UserAccount UserAccount { get; set; }
    }
}

namespace Magma.DomainModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("BlogsMaster")]
    public partial class BlogsMaster
    {
        public int Id { get; set; }

        public int Blog_Id { get; set; }

        public int Category_Id { get; set; }

        public int Type_Id { get; set; }

        public int Author_Id { get; set; }

        public byte? Blog_ContentPresent { get; set; }

        public virtual BlogCategory BlogCategory { get; set; }

        public virtual Blog Blog { get; set; }

        public virtual BlogType BlogType { get; set; }

        public virtual UserAccount UserAccount { get; set; }
    }
}

namespace Magma.DomainModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class BlogView
    {
        public int Id { get; set; }

        public int Blog_Id { get; set; }

        [Required]
        [StringLength(50)]
        public string View_From { get; set; }

        public long View_Count { get; set; }

        public DateTime View_At { get; set; }

        public virtual Blog Blog { get; set; }
    }
}

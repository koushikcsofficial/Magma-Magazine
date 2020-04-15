using System;
using System.ComponentModel.DataAnnotations;

namespace Magma.DomainModels
{
    public class BlogView
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
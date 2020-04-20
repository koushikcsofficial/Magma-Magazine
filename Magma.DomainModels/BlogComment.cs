namespace Magma.DomainModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class BlogComment
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BlogComment()
        {
            BlogComments1 = new HashSet<BlogComment>();
        }

        public int Id { get; set; }

        public int Blog_Id { get; set; }

        public int User_Id { get; set; }

        public int? Parent_Id { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string Comment { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BlogComment> BlogComments1 { get; set; }

        public virtual BlogComment BlogComment1 { get; set; }

        public virtual Blog Blog { get; set; }

        public virtual UserAccount UserAccount { get; set; }
    }
}

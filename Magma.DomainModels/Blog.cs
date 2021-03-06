namespace Magma.DomainModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class Blog
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Blog()
        {
            BlogComments = new HashSet<BlogComment>();
            BlogReactions = new HashSet<BlogReaction>();
            BlogReportsMasters = new HashSet<BlogReportsMaster>();
            BlogsMasters = new HashSet<BlogsMaster>();
            BlogViews = new HashSet<BlogView>();
        }

        [Key]
        public int Blog_Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Blog_Title { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string Blog_Description { get; set; }

        public DateTime Blog_CreatedAt { get; set; }

        public byte Blog_IsActive { get; set; }

        public DateTime? Blog_UpdatedAt { get; set; }

        public DateTime? Blog_DeactiveAt { get; set; }

        [StringLength(50)]
        public string Blog_CreatedFrom { get; set; }

        [StringLength(50)]
        public string Blog_UpdatedFrom { get; set; }

        [StringLength(50)]
        public string Blog_DeactiveFrom { get; set; }

        public int? Blog_DeactiveBy { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BlogComment> BlogComments { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BlogReaction> BlogReactions { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BlogReportsMaster> BlogReportsMasters { get; set; }

        public virtual UserAccount UserAccount { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BlogsMaster> BlogsMasters { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BlogView> BlogViews { get; set; }
    }
}

namespace Magma.DomainModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class Content
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Content()
        {
            UserDetails = new HashSet<UserDetail>();
        }

        [Key]
        public int Content_Id { get; set; }

        public int User_Uploaded { get; set; }

        public int? Blog_Id { get; set; }

        [Required]
        [StringLength(200)]
        public string Content_Type { get; set; }

        [Required]
        [StringLength(100)]
        public string File_Name { get; set; }

        [Required]
        public byte[] Data { get; set; }

        public DateTime Uploaded_At { get; set; }

        [Required]
        [StringLength(50)]
        public string Uploaded_From { get; set; }

        public byte Content_IsActive { get; set; }

        public DateTime? Content_DeactiveAt { get; set; }

        public string Content_Link { get; set; }

        public DateTime? Content_UpdatedAt { get; set; }

        public virtual UserAccount UserAccount { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserDetail> UserDetails { get; set; }
    }
}

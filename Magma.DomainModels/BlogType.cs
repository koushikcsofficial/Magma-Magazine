using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Magma.DomainModels
{
    public class BlogType
    {

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BlogType()
        {
            BlogsMasters = new HashSet<BlogsMaster>();
        }

        [Key]
        public int Type_Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Type_Name { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BlogsMaster> BlogsMasters { get; set; }
    }
}
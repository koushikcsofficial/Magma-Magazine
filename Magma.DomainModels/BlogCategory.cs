using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Magma.DomainModels
{
    public class BlogCategory
    {

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BlogCategory()
        {
            BlogsMasters = new HashSet<BlogsMaster>();
        }

        [Key]
        public int Category_Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Category_Name { get; set; }

        public string Category_Image { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BlogsMaster> BlogsMasters { get; set; }
    }
}
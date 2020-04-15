using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Magma.DomainModels
{
    public class Blog
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Blog()
        {
            AudioBlogs = new HashSet<AudioBlog>();
            BlogComments = new HashSet<BlogComment>();
            BlogReactionsMasters = new HashSet<BlogReactionsMaster>();
            BlogsMasters = new HashSet<BlogsMaster>();
            BlogViews = new HashSet<BlogView>();
            PictureBlogs = new HashSet<PictureBlog>();
            VideoBlogs = new HashSet<VideoBlog>();
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

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AudioBlog> AudioBlogs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BlogComment> BlogComments { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BlogReactionsMaster> BlogReactionsMasters { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BlogsMaster> BlogsMasters { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BlogView> BlogViews { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PictureBlog> PictureBlogs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VideoBlog> VideoBlogs { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Magma.DomainModels
{
    public class Blog
    {
        public Blog()
        {
            this.AudioBlogs = new HashSet<AudioBlog>();
            this.BlogComments = new HashSet<BlogComment>();
            this.BlogReactionsMasters = new HashSet<BlogReactionsMaster>();
            this.BlogsMasters = new HashSet<BlogsMaster>();
            this.BlogViews = new HashSet<BlogView>();
            this.PictureBlogs = new HashSet<PictureBlog>();
            this.VideoBlogs = new HashSet<VideoBlog>();
        }
        [Key]
        public int Blog_Id { get; set; }
        public string Blog_Title { get; set; }
        public string Blog_Description { get; set; }
        public System.DateTime Blog_CreatedAt { get; set; }
        public byte Blog_IsActive { get; set; }
        public DateTime? Blog_UpdatedAt { get; set; }
        public DateTime? Blog_DeactiveAt { get; set; }
        public string Blog_CreatedFrom { get; set; }
        public string Blog_UpdatedFrom { get; set; }
        public string Blog_DeactiveFrom { get; set; }

        
        public virtual ICollection<AudioBlog> AudioBlogs { get; set; }

        public virtual ICollection<BlogComment> BlogComments { get; set; }

        public virtual ICollection<BlogReactionsMaster> BlogReactionsMasters { get; set; }

        public virtual ICollection<BlogsMaster> BlogsMasters { get; set; }

        public virtual ICollection<BlogView> BlogViews { get; set; }

        public virtual ICollection<PictureBlog> PictureBlogs { get; set; }

        public virtual ICollection<VideoBlog> VideoBlogs { get; set; }
    }
}
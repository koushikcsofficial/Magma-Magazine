using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Magma.DomainModels
{
    public class BlogCategory
    {
        
        public BlogCategory()
        {
            this.BlogsMasters = new HashSet<BlogsMaster>();
        }
        [Key]
        public int Category_Id { get; set; }
        public string Category_Name { get; set; }
        public string Category_Image { get; set; }

        public virtual ICollection<BlogsMaster> BlogsMasters { get; set; }
    }
}
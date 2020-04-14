using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Magma.DomainModels
{
    public class BlogType
    {
        
        public BlogType()
        {
            this.BlogsMasters = new HashSet<BlogsMaster>();
        }

        [Key]
        public int Type_Id { get; set; }
        public string Type_Name { get; set; }

        
        public virtual ICollection<BlogsMaster> BlogsMasters { get; set; }
    }
}
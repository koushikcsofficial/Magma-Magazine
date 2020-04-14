using System.Collections.Generic;

namespace Magma.DomainModels
{
    public class BlogComment
    {
        
        public BlogComment()
        {
            this.BlogComments1 = new HashSet<BlogComment>();
        }

        public int Id { get; set; }
        public int Blog_Id { get; set; }
        public int User_Id { get; set; }
        public int? Parent_Id { get; set; }
        public string Comment { get; set; }

        
        public virtual ICollection<BlogComment> BlogComments1 { get; set; }
        public virtual BlogComment BlogComment1 { get; set; }
        public virtual Blog Blog { get; set; }
        public virtual UserAccount UserAccount { get; set; }
    }
}
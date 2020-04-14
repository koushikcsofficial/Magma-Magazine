using System.ComponentModel.DataAnnotations;

namespace Magma.DomainModels
{
    public class BlogView
    {
        [Key]
        public int Id { get; set; }
        public int Blog_Id { get; set; }
        public string View_From { get; set; }
        public long View_Count { get; set; }
        public System.DateTime View_At { get; set; }

        public virtual Blog Blog { get; set; }
    }
}
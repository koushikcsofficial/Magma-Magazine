using System.ComponentModel.DataAnnotations;

namespace Magma.DomainModels
{
    public class BlogsMaster
    {
        [Key]
        public int Id { get; set; }
        public int Blog_Id { get; set; }
        public int Category_Id { get; set; }
        public int Type_Id { get; set; }
        public int Author_Id { get; set; }

        public virtual BlogCategory BlogCategory { get; set; }
        public virtual Blog Blog { get; set; }
        public virtual BlogType BlogType { get; set; }
        public virtual UserAccount UserAccount { get; set; }
    }
}
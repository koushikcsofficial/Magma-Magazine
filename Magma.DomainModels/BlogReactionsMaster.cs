using System.ComponentModel.DataAnnotations;

namespace Magma.DomainModels
{
    public class BlogReactionsMaster
    {
        [Key]
        public int Id { get; set; }
        public int Blog_Id { get; set; }
        public int Reaction_Id { get; set; }
        public int User_Id { get; set; }

        public virtual Blog Blog { get; set; }
        public virtual UserAccount UserAccount { get; set; }
    }
}
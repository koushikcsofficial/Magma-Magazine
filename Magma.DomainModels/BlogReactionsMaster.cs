using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Magma.DomainModels
{
    [Table("BlogReactionsMaster")]
    public class BlogReactionsMaster
    {
        public int Id { get; set; }

        public int Blog_Id { get; set; }

        public int Reaction_Id { get; set; }

        public int User_Id { get; set; }

        public virtual Blog Blog { get; set; }

        public virtual UserAccount UserAccount { get; set; }
    }
}
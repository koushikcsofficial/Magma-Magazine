using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magma.DomainModels
{
    public class BlogReaction
    {
        public int Id { get; set; }

        public int Blog_Id { get; set; }

        public int Reaction_Id { get; set; }

        public int User_Id { get; set; }

        public virtual Blog Blog { get; set; }

        public virtual UserAccount UserAccount { get; set; }
    }
}

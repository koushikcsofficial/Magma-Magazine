using System.ComponentModel.DataAnnotations;

namespace Magma.DomainModels
{
    public class PictureBlog
    {
        public int Id { get; set; }

        public int Blog_Id { get; set; }

        [Required]
        public string Blog_ImagePath { get; set; }

        public virtual Blog Blog { get; set; }
    }
}
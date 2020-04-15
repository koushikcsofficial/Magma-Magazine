using System.ComponentModel.DataAnnotations;

namespace Magma.DomainModels
{
    public class AudioBlog
    {
        public int Id { get; set; }

        public int Blog_Id { get; set; }

        [Required]
        public string Audio_Path { get; set; }

        public string Audio_Link { get; set; }

        [Required]
        public string Audio_Thumbail { get; set; }

        public virtual Blog Blog { get; set; }
    }
}

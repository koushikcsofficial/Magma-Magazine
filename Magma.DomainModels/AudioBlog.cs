using System.ComponentModel.DataAnnotations;

namespace Magma.DomainModels
{
    public class AudioBlog
    {
        [Key]
        public int Id { get; set; }
        public int Blog_Id { get; set; }
        public string Audio_Path { get; set; }
        public string Audio_Link { get; set; }
        public string Audio_Thumbail { get; set; }

        public virtual Blog Blog { get; set; }
    }
}

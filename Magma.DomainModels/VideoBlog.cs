using System.ComponentModel.DataAnnotations;

namespace Magma.DomainModels
{
    public class VideoBlog
    {
        [Key]
        public int Id { get; set; }
        public int Blog_Id { get; set; }
        public string Video_Link { get; set; }
        public string Video_Path { get; set; }

        public virtual Blog Blog { get; set; }
    }
}
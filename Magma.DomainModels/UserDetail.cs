using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Magma.DomainModels
{
    public class UserDetail
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int User_Id { get; set; }

        [Required]
        [StringLength(50)]
        public string User_FirstName { get; set; }

        [Required]
        [StringLength(50)]
        public string User_LastName { get; set; }

        public int User_Age { get; set; }

        [StringLength(13)]
        public string User_Mobile { get; set; }

        [Required]
        [StringLength(10)]
        public string User_Gender { get; set; }

        [StringLength(255)]
        public string User_Avatar { get; set; }

        public virtual UserAccount UserAccount { get; set; }
    }
}
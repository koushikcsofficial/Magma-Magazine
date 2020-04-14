using System.ComponentModel.DataAnnotations;

namespace Magma.DomainModels
{
    public class UserDetail
    {
        [Key]
        public int User_Id { get; set; }
        public string User_FirstName { get; set; }
        public string User_LastName { get; set; }
        public int User_Age { get; set; }
        public string User_Mobile { get; set; }
        public string User_Gender { get; set; }
        public string User_Avatar { get; set; }

        public virtual UserAccount UserAccount { get; set; }
    }
}
using System.ComponentModel.DataAnnotations;

namespace UserForm.Models
{
    public class UserModel
    {
        [Required]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool Active { get; set; }
        [Required]
        public string Address { get; set; }
    }
}

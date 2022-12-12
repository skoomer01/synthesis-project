using System.ComponentModel.DataAnnotations;

namespace WebsiteApplication.Models
{
    public class Login
    {
        [Required]
        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}

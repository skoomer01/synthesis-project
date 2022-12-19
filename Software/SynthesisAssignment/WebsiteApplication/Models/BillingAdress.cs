using System.ComponentModel.DataAnnotations;

namespace WebsiteApplication.Models
{
    public class BillingAdress
    {
        [Required]
        public string Name { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public string PostalCode { get; set; }
    }
}

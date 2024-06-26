using System.ComponentModel.DataAnnotations;

namespace TuesTestWebApi.Dtos.Customer
{
    public class CreateCustomerDto
    {
        [Required]
        [MaxLength(30)]
        public string FirstName { get; set; } = string.Empty;  
        [Required]
        [MaxLength(30)]
        public string LastName { get; set; } = string.Empty;
        [Required]
        public int Age { get; set; }
        [Required]
        [MaxLength(20)]
        public string PhoneNo { get; set; }
        [Required]
        [MaxLength(70)]
        [EmailAddress]
        public string Email { get; set; } = string.Empty;
        [Required]
        public string Address { get; set; } = string.Empty;

    }
}

using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace TuesTestWebApi.Model
{
    [Index("Email", IsUnique = true)]
    [Index("PhoneNo", IsUnique =true)]
    public class Customer
    {

        public Guid Id { get; set; }
        [StringLength(50)]
        public string FirstName { get; set; } = string.Empty;
        [StringLength(50)]
        public string LastName { get; set; } = string.Empty;
        public int Age { get; set; }
        public string PhoneNo { get; set; }
        public string Email { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public int Tier { get; set; } = 1;

        public virtual Account? Account { get; set; }
        public DateTime CreatedAt { get; set; }= DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

    }
}

using System.ComponentModel.DataAnnotations.Schema;

namespace TuesTestWebApi.Dtos.Transaction
{
    public class TransactionDto
    {

        public Guid id { get; set; }
        public Guid CustomerId { get; set; }
        public string TransactionType { get; set; } = string.Empty;
        public decimal Amount { get; set; }
        public Guid AccountId { get; set; }
      
    }
}

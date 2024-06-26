using System.ComponentModel.DataAnnotations.Schema;
using TuesTestWebApi.Model.Enum;

namespace TuesTestWebApi.Model
{
    public class Transactions
    {
        public Guid id { get; set; }
        public decimal Amount { get; set; }
        public TransactionType TransactionType { get; set; }
        public Guid AccountId {  get; set; }
        [ForeignKey("AccountId")]
        public Account? Account { get; set; }
        [ForeignKey("CustomerId")]
        public Customer? Customer { get; set; }
        public Guid CustomerId { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;


     
    }
}

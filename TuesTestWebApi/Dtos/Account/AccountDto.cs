namespace TuesTestWebApi.Dtos.Account
{
    public class AccountDto
    {
        public Guid CustomerId { get; set; }
        public string AccountNo { get; set; }
        public decimal AccountBalance { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;

    }
}

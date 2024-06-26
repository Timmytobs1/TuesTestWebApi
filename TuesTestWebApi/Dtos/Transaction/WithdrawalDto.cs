namespace TuesTestWebApi.Dtos.Transaction
{
    public class WithdrawalDto
    {
        public Guid AccountId { get; set; }
        public decimal Amount { get; set; }
    }
}

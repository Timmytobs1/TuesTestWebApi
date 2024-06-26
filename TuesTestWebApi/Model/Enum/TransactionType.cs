using System.ComponentModel.DataAnnotations;

namespace TuesTestWebApi.Model.Enum
{
    public enum TransactionType
    {
        [Display(Name = "Withdraw")]
        WITHDRAW,
        [Display(Name = "Deposit")]
        DEPOSIT,

    }
}

using TuesTestWebApi.Dtos.Account;
using TuesTestWebApi.Dtos.Customer;
using TuesTestWebApi.Model;

namespace TuesTestWebApi.Mappers
{
    public static class AccountMapper
    {

        public static AccountDto ToAccountDtoFromModel(this Account account)
        {
            return new AccountDto
            {
                CustomerId = account.CustomerId,
                AccountNo = account.AccountNo,
                AccountBalance = account.AccountBalance,
                CreatedAt = account.CreatedAt,
            };
        }
    }
}

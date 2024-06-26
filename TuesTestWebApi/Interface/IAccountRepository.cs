using TuesTestWebApi.Dtos.Account;
using TuesTestWebApi.Dtos.Customer;
using TuesTestWebApi.Model;

namespace TuesTestWebApi.Interface
{
    public interface IAccountRepository
    {
        public List<AccountDto> GetAllAccounts();
        public AccountDto GetAccountById(Guid id);
        public AccountDto CreateAccount(Guid customerId);
        public string GenerateAccountNumber();
    }
}

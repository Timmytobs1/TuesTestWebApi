using TuesTestWebApi.Data;
using TuesTestWebApi.Dtos.Account;
using TuesTestWebApi.Interface;
using TuesTestWebApi.Mappers;
using TuesTestWebApi.Model;

namespace TuesTestWebApi.Repository
{
    public class AccountRepository : IAccountRepository
    {
        private readonly ApplicationDbContext _context;
        public AccountRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public bool CheckAccount(Guid id)
        {
            throw new NotImplementedException();
        }

  
        public AccountDto CreateAccount(Guid customerId)
        {
            var account = new Account
            {
                CustomerId = customerId,
                AccountNo = GenerateAccountNumber()
            };

            _context.Accounts.Add(account);
            _context.SaveChanges();

            return account.ToAccountDtoFromModel();
        }

        public AccountDto DeleteAccount(int id)
        {
            throw new NotImplementedException();
        }

    

        public string GenerateAccountNumber()
        {
            Random random = new Random();
            string digits = "2345678910";
            string accountNo = "";
            int length = 10;
            for (int i = 0; i < length; i++)
            {
                accountNo += digits[random.Next(digits.Length)];
            }
            return accountNo;
        }

        public AccountDto GetAccountById(Guid id)
        {
            var accounts = _context.Accounts.FirstOrDefault(x => x.Id == id);
            if (accounts == null)
            {
                return null;
            }
            return accounts.ToAccountDtoFromModel();
        }

        public List<AccountDto> GetAccounts(Guid id)
        {
            var accounts = _context.Accounts.Select(x => x.ToAccountDtoFromModel()).ToList();
            return accounts;
        }

        public List<AccountDto> GetAllAccounts()
        {
            throw new NotImplementedException();
        }
    }
}

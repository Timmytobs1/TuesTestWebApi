using System.Transactions;
using Microsoft.AspNetCore.Authentication;
using TuesTestWebApi.Data;
using TuesTestWebApi.Dtos.Transaction;
using TuesTestWebApi.Interface;
using TuesTestWebApi.Model;
using TuesTestWebApi.Model.Enum;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace TuesTestWebApi.Repository
{
    public class TransactionRepository : ITransactionRepository
    {
        private readonly ApplicationDbContext _context;
        public TransactionRepository(ApplicationDbContext context)
        {
            _context = context;
        }


        public TransactionDto Deposit(DepositDto depositDto)
        {
            var account = _context.Accounts.FirstOrDefault(x => x.Id == depositDto.AccountId);
            if (account == null)
            {
                throw new Exception("Account Does Not Exist");
            }
            var customer = _context.Customers.FirstOrDefault(y => y.Id == account.CustomerId);

           var transaction = new Model.Transactions
            {
                AccountId = depositDto.AccountId,
                Amount = depositDto.Amount,
                CustomerId = account.CustomerId,
                TransactionType = TransactionType.DEPOSIT
            };
            if (depositDto.Amount < 0)
            {
                throw new Exception("invalid amount");
            }
            if (customer.Tier == 1)
            {
                if (account.AccountBalance + depositDto.Amount > 50000)
                {
                    throw new Exception("Tier Balance Exceeded");
                }
                else
                {
                    account.AccountBalance += depositDto.Amount;
                }
            }
            if (customer.Tier == 2)
            {
                if (account.AccountBalance + depositDto.Amount > 100000)
                {
                    throw new Exception("Balance Exceeded");
                }
                else
                {
                    account.AccountBalance += depositDto.Amount;
                }
            }
            if (customer.Tier == 3)
            {
                account.AccountBalance += depositDto.Amount;
            }
            if (depositDto.Amount < 0)
            {
                throw new Exception("invalid amount");
            }

            _context.Transactions.Add(transaction);
            _context.SaveChanges();

            var transactionDto = new TransactionDto
            {
                AccountId = account.Id,
                Amount = depositDto.Amount,
                CustomerId = account.CustomerId,
                TransactionType = "Deposit",
            };

            return transactionDto;
        }

        public TransactionDto Withdraw(WithdrawalDto withdrawDto)
        {
            var account = _context.Accounts.FirstOrDefault(x => x.Id == withdrawDto.AccountId);
            if (account == null)
            {
                return null;
            }
            if (account.AccountBalance < withdrawDto.Amount)
            {
                throw new Exception("Insufficient Balance");
            }
            if (withdrawDto.Amount < 0)
            {
                throw new Exception("invalid amount");
            }
            var customer = _context.Customers.FirstOrDefault(y => y.Id == account.CustomerId);
            var transaction = new Model.Transactions
            {
                AccountId = withdrawDto.AccountId,
                Amount = withdrawDto.Amount,
                CustomerId = account.CustomerId,
                TransactionType = TransactionType.WITHDRAW
            };
            account.AccountBalance -= withdrawDto.Amount;
            _context.Transactions.Add(transaction);
            _context.SaveChanges();
            var transactionDto = new TransactionDto
            {
                AccountId = account.Id,
                Amount = withdrawDto.Amount,
                CustomerId = account.CustomerId,
                TransactionType = "Withdraw",
            };
            return transactionDto;
        }

            public List<TransactionDto> GetAllTransactions()
        {
            throw new NotImplementedException();
        }

        public TransactionDto GetTransactionById(Guid id)
        {
            throw new NotImplementedException();
        }

      
    }
}

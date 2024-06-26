﻿using TuesTestWebApi.Dtos.Transaction;

namespace TuesTestWebApi.Interface
{
    public interface ITransactionRepository
    {

        public List<TransactionDto> GetAllTransactions();
        public TransactionDto GetTransactionById(Guid id);
        public TransactionDto Withdraw(WithdrawalDto withdrawDto);
        public TransactionDto Deposit(DepositDto depositDto);

    }
}

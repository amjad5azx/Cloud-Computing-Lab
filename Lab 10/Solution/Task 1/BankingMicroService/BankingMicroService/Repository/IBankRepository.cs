using BankingMicroService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankingMicroService.Repository
{
    public interface IBankRepository
    {
        void AddTransaction(Bank_Transaction transaction);
        Bank_Transaction GetTransactionById(int transactionId);
        IEnumerable<Bank_Transaction> GetAllTransactions();
    }
}

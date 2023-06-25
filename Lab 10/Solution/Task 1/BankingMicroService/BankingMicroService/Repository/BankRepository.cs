using BankingMicroService.DBContext;
using BankingMicroService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankingMicroService.Repository
{
    public class BankRepository : IBankRepository
    {
        private readonly TransactionContext _context;

        public BankRepository(TransactionContext context)
        {
            _context = context;
        }

        public void AddTransaction(Bank_Transaction transaction)
        {
            _context.Bank_Transactions.Add(transaction);
            _context.SaveChanges();
        }

        public IEnumerable<Bank_Transaction> GetAllTransactions()
        {
            return _context.Bank_Transactions.ToList();
        }

        public Bank_Transaction GetTransactionById(int transactionId)
        {
            return _context.Bank_Transactions.FirstOrDefault(t => t.TransactionId == transactionId);
        }
    }
}

using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BankingMicroService.Models;

namespace BankingMicroService.DBContext
{
    public class TransactionContext : DbContext
    {
        public TransactionContext(DbContextOptions<TransactionContext> options) : base(options)
        {
        }

        public DbSet<Bank_Transaction> Bank_Transactions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Bank_Transaction>().HasData(new Bank_Transaction
                {
                    TransactionId = 1,
                    AccountNumber = "123456789",
                    Amount = 100.00,
                    TransactionDate = DateTime.Now,
                    TransactionType = "Deposit"
            },
                new Bank_Transaction
                {
                    TransactionId = 2,
                    AccountNumber = "987654321",
                    Amount = 50.00,
                    TransactionDate = DateTime.Now,
                    TransactionType = "Withdrawal"
            }
            );
        }
    }

}

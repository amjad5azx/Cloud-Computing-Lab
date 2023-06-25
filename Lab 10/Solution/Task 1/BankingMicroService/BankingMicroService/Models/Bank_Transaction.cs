using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BankingMicroService.Models
{
    public class Bank_Transaction
    {
        [Key]
        public int TransactionId { get; set; }
        public string AccountNumber { get; set; }
        public double Amount { get; set; }
        public DateTime TransactionDate { get; set; }
        public string TransactionType { get; set; }
    }

}

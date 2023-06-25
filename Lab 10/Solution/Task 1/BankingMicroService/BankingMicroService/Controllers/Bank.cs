using BankingMicroService.Models;
using BankingMicroService.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BankingMicroService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BankController : ControllerBase
    {
        private readonly IBankRepository _bankRepository;

        public BankController(IBankRepository bankRepository)
        {
            _bankRepository = bankRepository;
        }

        [HttpPost]
        public IActionResult AddTransaction(Bank_Transaction transaction)
        {
            _bankRepository.AddTransaction(transaction);
            return Ok();
        }

        [HttpGet]
        public IActionResult GetAllTransactions()
        {
            var transactions = _bankRepository.GetAllTransactions();
            return Ok(transactions);
        }

        [HttpGet("{transactionId}")]
        public IActionResult GetTransactionById(int transactionId)
        {
            var transaction = _bankRepository.GetTransactionById(transactionId);
            if (transaction == null)
            {
                return NotFound();
            }
            return Ok(transaction);
        }
    }

}

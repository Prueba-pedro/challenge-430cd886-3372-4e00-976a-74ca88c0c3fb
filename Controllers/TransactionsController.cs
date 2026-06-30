using Microsoft.AspNetCore.Mvc;
using WebAPI.Models;
using WebAPI.Services;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TransactionsController : ControllerBase
    {
        private readonly TransactionService _transactionService;

        public TransactionsController(TransactionService transactionService)
        {
            _transactionService = transactionService;
        }

        [HttpPost]
        public IActionResult RegisterTransaction(Transaction transaction)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var result = _transactionService.RegisterTransaction(transaction);
            if (result == null)
                return BadRequest("Transaction already exists");

            return Ok(result);
        }

        [HttpGet("{userId}")]
        public IActionResult GetTransactionsByUserId(int userId)
        {
            var transactions = _transactionService.GetTransactionsByUserId(userId);
            return Ok(transactions);
        }
    }
}
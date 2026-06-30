using System.Collections.Generic;
using WebAPI.Models;
using WebAPI.Data;

namespace WebAPI.Services
{
    public class TransactionService
    {
        private readonly AppDbContext _context;

        public TransactionService(AppDbContext context)
        {
            _context = context;
        }

        public Transaction RegisterTransaction(Transaction transaction)
        {
            if (_context.Transactions.Any(t => t.Id == transaction.Id))
                return null;

            _context.Transactions.Add(transaction);
            _context.SaveChanges();
            return transaction;
        }

        public IEnumerable<Transaction> GetTransactionsByUserId(int userId)
        {
            return _context.Transactions.Where(t => t.UserId == userId);
        }
    }
}
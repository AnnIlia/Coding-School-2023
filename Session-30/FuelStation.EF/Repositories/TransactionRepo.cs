using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FuelStation.EF.Context;
using FuelStation.Model;
using Microsoft.EntityFrameworkCore;

namespace FuelStation.EF.Repositories
{
    public class TransactionRepo : IEntityRepo<Transaction>
    {
        public void Add(Transaction transaction)
        {
            using var context = new FuelStationDbContext();
            context.Add(transaction);
            context.SaveChanges();
        }

        public void Delete(int Id)
        {
            using var context = new FuelStationDbContext();
            var TransactionDb = context.Transactions
                .Where(transaction => transaction.Id == Id)
                .Include(transaction => transaction.TransactionLines)
                .Include(transaction => transaction.Customer)
                .Include(transaction => transaction.Employee)
                .SingleOrDefault();
            if (TransactionDb is null)
                throw new KeyNotFoundException($"Given id '{Id}' was not found");
            context.Remove(TransactionDb);
            context.SaveChanges();
        }

        public IList<Transaction> GetAll()
        {
            using var context = new FuelStationDbContext();
            return context.Transactions

                .Include(transaction => transaction.Customer)
                .Include(transaction => transaction.Employee)
                .Include(transaction => transaction.TransactionLines)
                    .ThenInclude(transactionLine => transactionLine.Item)
                .Include(transaction => transaction.TransactionLines)
                    .ThenInclude(transactionLine => transactionLine.Transaction)
                .ToList();
        }

        public Transaction? GetById(int Id)
        {
            using var context = new FuelStationDbContext();
            return context.Transactions
                .Where(transaction => transaction.Id == Id)

                .Include(transaction => transaction.Customer)
                .Include(transaction => transaction.Employee)
                .Include(transaction => transaction.TransactionLines)
                    .ThenInclude(transactionLine => transactionLine.Item)
                .Include(transaction => transaction.TransactionLines)
                    .ThenInclude(transactionLine => transactionLine.Transaction)
                .SingleOrDefault();
        }

        public void Update(int Id, Transaction transaction)
        {
            using var context = new FuelStationDbContext();
            var TransactionDb = context.Transactions
                .Where(transaction => transaction.Id == Id)
                .SingleOrDefault();
            if (TransactionDb is null)
                throw new KeyNotFoundException($"Given id '{Id}' was not found");
            TransactionDb.Date = transaction.Date;
            TransactionDb.TotalValue = transaction.TotalValue;
            TransactionDb.PaymentMethod = transaction.PaymentMethod;
            TransactionDb.CustomerId = transaction.CustomerId;
            TransactionDb.EmployeeId = transaction.EmployeeId;
            context.SaveChanges();
        }
    }
}
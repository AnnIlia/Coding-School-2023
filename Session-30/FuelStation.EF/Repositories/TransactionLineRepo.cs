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
    public class TransactionLineRepo : IEntityRepo<TransactionLine>
    {
        public void Add(TransactionLine transactionline)
        {
            using var context = new FuelStationDbContext();
            context.Add(transactionline);
            context.SaveChanges();
        }

        public void Delete(int Id)
        {
            using var context = new FuelStationDbContext();
            var TransactionLineDb = context.TransactionsLine.Where(transactionLine => transactionLine.Id == Id)
                .Include(transactionLine => transactionLine.Transaction)
                .Include(transactionLine => transactionLine.Item)
                .SingleOrDefault();
            if (TransactionLineDb is null)
                throw new KeyNotFoundException($"Given id '{Id}' was not found");
            context.Remove(TransactionLineDb);
            context.SaveChanges();
        }

        public IList<TransactionLine> GetAll()
        {
            using var context = new FuelStationDbContext();
            return context.TransactionsLine
            .Include(transactionLine => transactionLine.Transaction)
            .Include(transactionLine => transactionLine.Item)
            .ToList();
        }

        public TransactionLine? GetById(int Id)
        {
            using var context = new FuelStationDbContext();
            return context.TransactionsLine
                .Where(transactionLine => transactionLine.Id == Id)
                .Include(transactionLine => transactionLine.Transaction)
                .Include(transactionLine => transactionLine.Item)
                .SingleOrDefault();
        }

        public void Update(int Id, TransactionLine transactionline)
        {
            using var context = new FuelStationDbContext();
            var TransactionLineDb = context.TransactionsLine.Where(transactionLine => transactionLine.Id == Id)
                .Include(transactionLine => transactionLine.Transaction)
                .Include(transactionLine => transactionLine.Item)
                .SingleOrDefault();
            if (TransactionLineDb is null)
                throw new KeyNotFoundException($"Given id '{Id}' was not found");
            TransactionLineDb.Quantity = transactionline.Quantity;
            TransactionLineDb.ItemPrice = transactionline.ItemPrice;
            TransactionLineDb.NetValue = transactionline.NetValue;
            TransactionLineDb.DiscountPercent = transactionline.DiscountPercent;
            TransactionLineDb.DiscountValue = transactionline.DiscountValue;
            TransactionLineDb.TotalValue = transactionline.TotalValue;

            context.SaveChanges();
        }

        public IList<TransactionLine> GetAllWithTransactionID(int transactionId)
        {  
            using var context = new FuelStationDbContext();
            return context.TransactionsLine.Where(transaction => transaction.Id == transactionId)
                .ToList();
        }

    }

}



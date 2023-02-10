using CoffeeShop.EF.Context;
using CoffeeShop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.EF.Repositories
{
    public class TransactionRepository : IEntityRepository<Transaction>


    {
        public void Create(Transaction entity)
        {
            using var context = new CoffeeShopDbContext();
            context.Transactions.Add(entity);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            using var context = new CoffeeShopDbContext();
            var foundTransaction = context.Transactions.SingleOrDefault(transaction => transaction.Id == id);
            if (foundTransaction is null)
                return;
            context.Transactions.Remove(foundTransaction);
            context.SaveChanges();
        }

        public IList<Transaction> GetAll()
        {
            using var context = new CoffeeShopDbContext();
            return context.Transactions.ToList();
        }

        public Transaction? GetById(int id)
        {
            using var context = new CoffeeShopDbContext();
            return context.Transactions.Where(transaction => transaction.Id == id).SingleOrDefault();
        }

        public void Update(int id, Transaction entity)
        {
            using var context = new CoffeeShopDbContext();
            var foundTransaction = context.Transactions.SingleOrDefault();  
            if (foundTransaction is null) 
                return;

            foundTransaction.Date = entity.Date;
            foundTransaction.EmployeeId = entity.EmployeeId;
            foundTransaction.CustomerId = entity.CustomerId;
            foundTransaction.PaymentMethod = entity.PaymentMethod;
            foundTransaction.TotalPrice = entity.TotalPrice;
            
            context.SaveChanges();
        }
    }
}

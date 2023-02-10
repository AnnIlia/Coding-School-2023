using CoffeeShop.EF.Context;
using CoffeeShop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.EF.Repositories
{
    public class TransactionLineRepository : IEntityRepository<TransactionLine>


    {
        public void Create(TransactionLine entity)
        {
            using var context = new CoffeeShopDbContext();
            context.TransactionLines.Add(entity);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            using var context = new CoffeeShopDbContext();
            var foundTransactionLine = context.TransactionLines.SingleOrDefault(TransactionLine => TransactionLine.Id == id);
            if (foundTransactionLine is null)
                return;

            context.TransactionLines.Remove(foundTransactionLine);
            context.SaveChanges();
        }

        public IList<TransactionLine> GetAll()
        {
            using var context = new CoffeeShopDbContext();
            return context.TransactionLines.ToList();
        }

        public TransactionLine? GetById(int id)
        {
            using var context = new CoffeeShopDbContext();
            return context.TransactionLines.Where(TransactionLine => TransactionLine.Id == id).SingleOrDefault();
        }

        public void Update(int id, TransactionLine entity)
        {
            using var context = new CoffeeShopDbContext();
            var foundTransactionLine = context.TransactionLines.SingleOrDefault(TransactionLine => TransactionLine.Id == id);
            if (foundTransactionLine is null)
                return;

            foundTransactionLine.Quantity= entity.Quantity;
            foundTransactionLine.Price = entity.Price;
            foundTransactionLine.Product= entity.Product;
            foundTransactionLine.ProductId= entity.ProductId;
            foundTransactionLine.Discount= entity.Discount;
            foundTransactionLine.TotalPrice = entity.TotalPrice;

            context.SaveChanges();
        }

    }
   
}


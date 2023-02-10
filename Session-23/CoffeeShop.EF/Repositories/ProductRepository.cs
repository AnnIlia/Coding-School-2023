using CoffeeShop.EF.Context;
using CoffeeShop.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.EF.Repositories
{
    public class ProductRepository : IEntityRepository<Product>


    {
        
        public void Create(Product entity)
        {
            using var context = new CoffeeShopDbContext();
            context.Products.Add(entity);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            using var context = new CoffeeShopDbContext();
            var foundProduct = context.Products.SingleOrDefault(product => product.Id == id);
            if (foundProduct is null)
                return;
            context.Products.Remove(foundProduct);
            context.SaveChanges();
        }

        public IList<Product> GetAll()
        {
            using var context = new CoffeeShopDbContext();
            return context.Products.ToList();
        }

        public Product? GetById(int id)
        {
            using var context = new CoffeeShopDbContext();
            //join for the view - will be needed in the future. Session: 10/02/2023
            return context.Products.Include(product => product.ProductCategory).Where(product => product.Id == id).SingleOrDefault();
        }

        public void Update(int id, Product entity)
        {
            using var context = new CoffeeShopDbContext();
            var foundProduct = context.Products.SingleOrDefault(product => product.Id == id); 
            if (foundProduct is null) 
                return;

            foundProduct.Cost = entity.Cost;
            foundProduct.Code = entity.Code;
            foundProduct.Price = entity.Price;
            foundProduct.Descripion = entity.Description;
            foundProduct.ProductCategory = entity.ProductCategory;
            foundProduct.ProductCategoryId = entity.ProductCategoryId;
            context.SaveChanges();

        }
    }
}

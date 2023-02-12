using CoffeeShop.EF.Context;
using CoffeeShop.EF.Repositories;
using CoffeeShop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.EF.Repositories
{
    public class ProductCategoryRepository : IEntityRepository<ProductCategory>

    {
        public void Create(ProductCategory entity)
        {
            using var context = new CoffeeShopDbContext();
            context.ProductCategories.Add(entity);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            using var context = new CoffeeShopDbContext();
            var foundProductCategories = context.ProductCategories.SingleOrDefault(productCat => productCat.Id == id);
            if (foundProductCategories is null)
                return;
            context.ProductCategories.Remove(foundProductCategories);
            context.SaveChanges();
        }

        public IList<ProductCategory> GetAll()
        {
            using var context = new CoffeeShopDbContext();
            return context.ProductCategories.ToList();
        }

        public ProductCategory? GetById(int id)
        {
            using var context = new CoffeeShopDbContext();
            return context.ProductCategories.SingleOrDefault(category => category.Id == id);
        }

        public void Update(int id, ProductCategory entity)
        {
            using var context = new CoffeeShopDbContext();
            var foundProductCategories = context.ProductCategories.SingleOrDefault();
            if (foundProductCategories is null)
                return;

            foundProductCategories.Code = entity.Code;
            foundProductCategories.Description = entity.Description;
            foundProductCategories.ProductType = entity.ProductType;

            context.SaveChanges();
        }
    }
}

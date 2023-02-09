using CoffeeShop.EF.Context;
using CoffeeShop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.EF.Repositories
{
    public class CustomerRepository : IEntityRepository<Customer>
    {
        public void Create(Customer entity)
        {
            using var context = new CoffeeShopDbContext();
            context.Customers.Add(entity); 
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            using var context = new CoffeeShopDbContext();
            var customer = context.Customers.SingleOrDefault(x => x.Id == id);
            if (customer != null) 
                return;
            context.Customers.Remove(customer);
            context.SaveChanges();
        }

        public Customer GetById(int id)
        {
            using var context = new CoffeeShopDbContext();
        }

        public void Update(int id, Customer entity)
        {
            using var context = new CoffeeShopDbContext();
        }
    }
}

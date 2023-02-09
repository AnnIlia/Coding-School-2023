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
            var foundcustomer = context.Customers.SingleOrDefault(x => x.Id == id);
            if (foundcustomer != null) 
                return;
            context.Customers.Remove(foundcustomer);
            context.SaveChanges();
        }
        public IList<Customer> GetAll()
        {
            using var context = new CoffeeShopDbContext();
            return context.Customers.ToList();
        }
        
        
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

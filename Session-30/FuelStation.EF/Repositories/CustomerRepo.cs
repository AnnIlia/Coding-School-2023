using FuelStation.EF.Context;
using FuelStation.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FuelStation.EF.Repositories;
using Microsoft.EntityFrameworkCore;

namespace FuelStation.EF.Repositories
{
    public class CustomerRepo : IEntityRepo<Customer>
    {
        public void Add(Customer entity)
        {
            using var context = new FuelStationDbContext();
            context.Add(entity);
            context.SaveChanges();
        }

        public IList<Customer> GetAll()
        {
            using var context = new FuelStationDbContext();
            return context.Customers
                .Include(customer => customer.Transactions)
                .ToList();
        }
        public Customer? GetById(int Id)
        {
            using var context = new FuelStationDbContext();
            return context.Customers
                .Where(customer => customer.Id == Id)
                .Include(customer => customer.Transactions)
                .SingleOrDefault();
        }
        public void Update(int Id, Customer entity)
        {
            using var context = new FuelStationDbContext();
            var CustomerDb = context.Customers
                .Where(customer => customer.Id == Id)
                .Include(customer => customer.Transactions)
                .SingleOrDefault();
            if (CustomerDb is null) throw new KeyNotFoundException($"Given id '{Id}' was not found");
            CustomerDb.Name = entity.Name;
            CustomerDb.Surname = entity.Surname;
            CustomerDb.CardNumber = entity.CardNumber;
            context.SaveChanges();
        }
        public void Delete(int Id)
        {
            using var context = new FuelStationDbContext();
            var CustomerDb = context.Customers
                .Where(customer => customer.Id == Id)
                .Include(customer => customer.Transactions)
                .SingleOrDefault();
            if (CustomerDb is null)
                throw new KeyNotFoundException($"Given id '{Id}' was not found");
            context.Remove(CustomerDb);
            context.SaveChanges();
        }
    }
}
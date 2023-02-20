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
    public class EmployeeRepo : IEntityRepo<Employee>
    {
        public void Add(Employee entity)
        {
            using var context = new FuelStationDbContext();
            context.Add(entity);
            context.SaveChanges();
        }

        public void Delete(int Id)
        {
            using var context = new FuelStationDbContext();
            var EmployeeDb = context.Employees
                .Where(employee => employee.Id == Id)
                .Include(employee => employee.Transactions)
                .SingleOrDefault();
            if (EmployeeDb is null)
                throw new KeyNotFoundException($"Given id '{Id}' was not found");
            context.Remove(EmployeeDb);
            context.SaveChanges();
        }

        public IList<Employee> GetAll()
        {
            using var context = new FuelStationDbContext();
            return context.Employees
                .Include(employee => employee.Transactions)
                .ToList();
        }

        public Employee? GetById(int Id)
        {
            using var context = new FuelStationDbContext();
            return context.Employees
                .Where(employee => employee.Id == Id)
                .Include(employee => employee.Transactions)
                .SingleOrDefault();
        }

        public void Update(int Id, Employee entity)
        {
            using var context = new FuelStationDbContext();
            var EmployeeDb = context.Employees
                .Where(entity => entity.Id == Id)
                .Include(customer => customer.Transactions)
                .SingleOrDefault();
            if (EmployeeDb is null) throw new KeyNotFoundException($"Given id '{Id}' was not found");
            EmployeeDb.Name = entity.Name;
            EmployeeDb.Surname = entity.Surname;
            EmployeeDb.HireDateStart = entity.HireDateStart;
            EmployeeDb.HireDateEnd = entity.HireDateEnd;
            EmployeeDb.SallaryPerMonth = entity.SallaryPerMonth;
            EmployeeDb.EmployeeType = entity.EmployeeType;
            context.SaveChanges();
        }
    }
}
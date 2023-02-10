using CoffeeShop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.EF.Repositories
{
    public class EmployeeRepository : IEntityRepository<Employee>
    {
        public void Create(Employee entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IList<Employee> GetAll()
        {
            throw new NotImplementedException();
        }

        public Employee? GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(int id, Employee entity)
        {
            throw new NotImplementedException();
        }

        Employee? IEntityRepository<Employee>.GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}

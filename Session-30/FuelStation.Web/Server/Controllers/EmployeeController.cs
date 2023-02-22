using FuelStation.EF.Repositories;
using FuelStation.Model;
using FuelStation.Web.Shared.Employee;
using Microsoft.AspNetCore.Mvc;

namespace FuelStation.Web.Server.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class EmployeeController : Controller
    {
        private readonly IEntityRepo<Employee> _employeeRepo;
        public EmployeeController(IEntityRepo<Employee> employeeRepo)
        {
            _employeeRepo = employeeRepo;
        }

        //Index - GetAlL()
        [HttpGet]
        public async Task<IEnumerable<EmployeeDto>> Get()
        {
            var employeeList = _employeeRepo.GetAll();
            return employeeList.Select(employee => new EmployeeDto
            {
                Id = employee.Id,
                Name = employee.Name,
                Surname= employee.Surname,
                HireDateStart= employee.HireDateStart,
                HireDateEnd= employee.HireDateEnd,
                SallaryPerMonth= employee.SallaryPerMonth,
                EmployeeType= employee.EmployeeType
            });
        }

        //Create - Post
        [HttpPost]
        public async Task Post(EmployeeCreateDto employee)
        {
            var newEmployee = new Employee(employee.Name, employee.Surname, employee.SallaryPerMonth, employee.EmployeeType);
            //newEmployee.Name = employee.Name;
            //newEmployee.Surname = employee.Surname;
            //newEmployee.HireDateStart = employee.HireDateStart;
            //newEmployee.HireDateEnd = employee.HireDateEnd;
            //newEmployee.SallaryPerMonth = employee.SallaryPerMonth;
            //newEmployee.EmployeeType = employee.EmployeeType;
            newEmployee.Transactions = new();
            _employeeRepo.Add(newEmployee);
        }


        //Delete
        [HttpDelete("{Id}")]
        public async Task Delete(int id)
        {
            _employeeRepo.Delete(id);
        }

        //Edit - GetbyID
        [HttpGet("{Id}")]
        public async Task<EmployeeDto> GetById(int id)
        {
            var result = _employeeRepo.GetById(id);
            return new EmployeeDto
            {
                Id = id,
                Name = result.Name,
                Surname = result.Surname,
                HireDateStart = result.HireDateStart,
                HireDateEnd = result.HireDateEnd,
                SallaryPerMonth = result.SallaryPerMonth,
                EmployeeType = result.EmployeeType
            };
        }


        //Put
        public async Task Put(EmployeeDto employee)
        {
            var itemToUpdate = _employeeRepo.GetById(employee.Id);
            itemToUpdate.Id = employee.Id;
            itemToUpdate.Name = employee.Name;
            itemToUpdate.Surname = employee.Surname;
            itemToUpdate.HireDateStart = employee.HireDateStart;
            itemToUpdate.HireDateEnd = employee.HireDateEnd;
            itemToUpdate.SallaryPerMonth = employee.SallaryPerMonth; 
            _employeeRepo.Update(employee.Id, itemToUpdate);
        }
    }
}
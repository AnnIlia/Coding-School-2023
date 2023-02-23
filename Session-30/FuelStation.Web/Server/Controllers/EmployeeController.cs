using FuelStation.EF.Repositories;
using FuelStation.Model;
using FuelStation.Web.Shared;
using FuelStation.Web.Shared.Employee;
using Microsoft.AspNetCore.Mvc;

namespace FuelStation.Web.Server.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class EmployeeController : Controller
    {
        private readonly IEntityRepo<Employee> _employeeRepo;
        private readonly Validator _validator;

        public EmployeeController(IEntityRepo<Employee> employeeRepo, Validator validator)
        {
            _employeeRepo = employeeRepo;
            _validator = validator;
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
            newEmployee.Transactions = new();
            var employeeList = _employeeRepo.GetAll();
            if (_validator.CheckEmployeeLimits(employeeList.ToList(), newEmployee))
            {
                _employeeRepo.Add(newEmployee);
            }
            
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
        public async Task Put(EmployeeDto incomigEmployee)
        {
            var itemToUpdate = _employeeRepo.GetById(incomigEmployee.Id);
            itemToUpdate.Id = incomigEmployee.Id;
            itemToUpdate.Name = incomigEmployee.Name;
            itemToUpdate.Surname = incomigEmployee.Surname;
            itemToUpdate.HireDateStart = incomigEmployee.HireDateStart;
            itemToUpdate.HireDateEnd = incomigEmployee.HireDateEnd;
            itemToUpdate.EmployeeType = incomigEmployee.EmployeeType;
            itemToUpdate.SallaryPerMonth = incomigEmployee.SallaryPerMonth;
            var employeeList = _employeeRepo.GetAll();
            if (_validator.CheckEmployeeLimits(employeeList.ToList(), itemToUpdate))
            {
                _employeeRepo.Update(incomigEmployee.Id, itemToUpdate);

            }
        }
    }
}
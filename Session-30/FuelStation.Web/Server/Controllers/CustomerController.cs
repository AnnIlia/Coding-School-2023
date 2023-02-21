using FuelStation.EF.Repositories;
using FuelStation.Web.Shared.Customer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using FuelStation.Model;
using FuelStation.Web.Shared;

namespace FuelStation.Web.Server.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly IEntityRepo<Customer> _customerRepo;
        public CustomerController(IEntityRepo<Customer> customerRepo)
        {
            _customerRepo = customerRepo;
        }

        //Index - GetAlL()
        [HttpGet]
        public async Task<IEnumerable<CustomerListDto>> Get()
        {
            var customerList = _customerRepo.GetAll();
            return customerList.Select(customer => new CustomerListDto
            {
                Id = customer.Id,
                Name = customer.Name,
                Surname = customer.Surname,
                CardNumber = customer.CardNumber
            });
        }

        //Create - Post
        [HttpPost]
        public async Task Post(CustomerCreateDto customer)
        {
            var newCustomer = new Customer(customer.Name, customer.Surname, customer.CardNumber);
            newCustomer.Transactions = new();
            _customerRepo.Add(newCustomer);
        }


        //Delete
        [HttpDelete("{Id}")]
        public async Task Delete(int id)
        {
            _customerRepo.Delete(id);
        }

        //Edit - GetbyID
        [HttpGet("{Id}")]
        public async Task<CustomerEditDto> GetById(int id)
        {
            var result = _customerRepo.GetById(id);
            return new CustomerEditDto
            {
                Id = id,
                Name = result.Name,
                Surname = result.Surname,
                CardNumber = result.CardNumber    
                
            };
        }


        //Put
        public async Task Put(CustomerEditDto customer)
        {
            var itemToUpdate = _customerRepo.GetById(customer.Id);
            itemToUpdate.Id = customer.Id;
            itemToUpdate.Name = customer.Name;
            itemToUpdate.Surname = customer.Surname;
            itemToUpdate.CardNumber = customer.CardNumber;
            itemToUpdate.Transactions = customer.Transactions;
            _customerRepo.Update(customer.Id, itemToUpdate);
        }



    }
}

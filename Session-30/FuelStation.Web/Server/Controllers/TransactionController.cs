using FuelStation.EF.Repositories;
using FuelStation.Model;
using FuelStation.Web.Shared.Customer;
using FuelStation.Web.Shared.Transaction;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FuelStation.Web.Server.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class TransactionController : ControllerBase
    {
        private readonly IEntityRepo<Transaction> _transactionRepo;
        //private readonly IEntityRepo<CustomerRepo> _customerRepo;
        //private readonly IEntityRepo<EmployeeRepo> _employeeRepo;
        //private readonly IEntityRepo<ItemRepo> _itemRepo;

        public TransactionController(IEntityRepo<Transaction> transactionRepo)

        {
            _transactionRepo = transactionRepo;
        }
        public async Task Put(TransactionEditDto transaction)
        {
            var itemToUpdate = _transactionRepo.GetById(transaction.Id);
            itemToUpdate.Date = transaction.Date;
            itemToUpdate.PaymentMethod = transaction.PaymentMethod;
            itemToUpdate.TotalValue = transaction.TotalValue;
            itemToUpdate.CustomerId = transaction.CustomerId;
            itemToUpdate.EmployeeId = transaction.EmployeeId;
            _transactionRepo.Update(transaction.Id, itemToUpdate);
        }

        [HttpGet]
        public async Task<IEnumerable<TransactionListDto>> Get()
        {
            var result = _transactionRepo.GetAll();
            return result.Select(transaction => new TransactionListDto
            {
                Id = transaction.Id,
                Date = transaction.Date,
                PaymentMethod = transaction.PaymentMethod,
                TotalValue = transaction.TotalValue,
                CustomerId = transaction.Customer.Id,
                EmployeeId = transaction.Employee.Id
            }).ToList();
        }

        [HttpGet("{id}")]
        public async Task<TransactionEditDto> GetById(int id)
        {
            var result = _transactionRepo.GetById(id);
            return new TransactionEditDto
            {
                Id = id,
                Date = result.Date,
                CustomerId = result.CustomerId,
                EmployeeId = result.EmployeeId,
                PaymentMethod = result.PaymentMethod,
                TotalValue = result.TotalValue
            };
        }

        [HttpPost]
        public async Task Post(TransactionEditDto transaction)
        {
            var newTransaction = new Transaction(transaction.Date, transaction.PaymentMethod, transaction.TotalValue);
            newTransaction.CustomerId = transaction.CustomerId;
            newTransaction.EmployeeId = transaction.EmployeeId;
            _transactionRepo.Add(newTransaction);
        }

        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            _transactionRepo.Delete(id);
        }
    }
}

    
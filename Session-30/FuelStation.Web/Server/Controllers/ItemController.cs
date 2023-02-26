using FuelStation.EF.Repositories;
using FuelStation.Model;
using FuelStation.Web.Shared.Item;
using Microsoft.AspNetCore.Mvc;

namespace FuelStation.Web.Server.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ItemController : Controller
    {
        private readonly IEntityRepo<Item> _itemRepo;
        public ItemController(IEntityRepo<Item> itemRepo)
        {
            _itemRepo = itemRepo;
        }

        //Index - GetAlL()
        [HttpGet]
        public async Task<IEnumerable<ItemDto>> Get()
        {
            var itemList = _itemRepo.GetAll();
            return itemList.Select(item => new ItemDto
            {
                Id = item.Id,
                Code = item.Code,
                Description = item.Description,
                ItemType = item.ItemType,
                Price = item.Price,
                Cost = item.Cost
            });
        }

        //Create - Post
        [HttpPost]
        public async Task Post(ItemCreateDto item)
        {
            var newItem = new Item();
            newItem.Code = item.Code;
            newItem.Description = item.Description;
            newItem.ItemType = item.ItemType;
            newItem.Price = item.Price;
            newItem.Cost = item.Cost;
            newItem.TransactionLines = new();
            _itemRepo.Add(newItem);
        }


        //Delete
        [HttpDelete("{Id}")]
        public async Task Delete(int id)
        {
            _itemRepo.Delete(id);
        }

        //Edit - GetbyID
        [HttpGet("{Id}")]
        public async Task<ItemDto> GetById(int id)
        {
            var result = _itemRepo.GetById(id);
            return new ItemDto
            {
                Id = id,
                Code = result.Code,
                Description = result.Description,
                ItemType = result.ItemType,
                Price = result.Price,
                Cost = result.Cost


            };
        }


        //Put
        public async Task Put(ItemDto item)
        {
            var itemToUpdate = _itemRepo.GetById(item.Id);
            itemToUpdate.Id = item.Id;
            itemToUpdate.Code = item.Code;
            itemToUpdate.Description = item.Description;
            itemToUpdate.ItemType = item.ItemType;
            itemToUpdate.Price = item.Price;
            itemToUpdate.Cost = item.Cost;
            _itemRepo.Update(item.Id, itemToUpdate);
        }
    }
}

using SportsShop.WebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsShop.WebApi.Services
{
    interface IItemService
    {
        Task<IEnumerable<Item>> GetItemsList();
        Task<Item> GetItemById(int id);
        Task<Item> CreateItem(Item item);
        Task UpdateItem(Item item);
        Task DeleteItem(Item item);
    }
}

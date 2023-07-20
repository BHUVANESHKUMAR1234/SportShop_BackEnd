using SportsShop.WebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsShop.WebApi.Services
{
    interface IOrderService
    {
        Task<IEnumerable<Order>> GetOrderList();
        Task<Order> GetOrderById(int id);
        Task<Order> CreateOrder(Order order);
        Task UpdateOrder(Order order);
        Task DeleteOrder(Order order);
    }
}

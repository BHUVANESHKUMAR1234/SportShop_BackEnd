using SportsShop.WebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsShop.WebApi.Services
{
    public class OrderService : IOrderService
    {
        public Task<Order> CreateOrder(Order order)
        {
            throw new NotImplementedException();
        }

        public Task DeleteOrder(Order order)
        {
            throw new NotImplementedException();
        }

        public Task<Order> GetOrderById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Order>> GetOrderList()
        {
            throw new NotImplementedException();
        }

        public Task UpdateOrder(Order order)
        {
            throw new NotImplementedException();
        }
    }
}

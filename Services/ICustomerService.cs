using SportsShop.WebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsShop.WebApi.Services
{
    interface ICustomerService
    {
        Task<IEnumerable<Customer>> GetCustomersList();
        Task<Customer> GetCustomerById(int id);
        Task<Customer> CreateCustomer(Customer customer);
        Task UpdateCustomer(Customer customer);
        Task DeleteCustomer(Customer customer);
    }
}
